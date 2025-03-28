using OutSystems.RuntimePublic.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutSystems.NssSQLCMD.Parser {
    public class ContextualQueryParser {


        private static readonly Regex SQL_LITERALS = new Regex(@"(--.*)|(/\*(.|[\r\n])*?\*/)|('(''|[^'\r\n])*')", RegexOptions.Compiled);

        private static readonly Regex ENTITY_STAR_REF = new Regex(@"\{([A-Za-z][A-Za-z0-9_]*)\}\.\*", RegexOptions.Compiled);
        private static readonly Regex ENTITY_ATTRIBUTE_REF = new Regex(@"\{([A-Za-z][A-Za-z0-9_]*)\}\.\[([A-Za-z][A-Za-z0-9_]*)\]", RegexOptions.Compiled);
        private static readonly Regex ENTITY_REF = new Regex(@"\{([A-Za-z][A-Za-z0-9_]*)\}", RegexOptions.Compiled);


        private readonly IDictionary<string, Entity> entitiesByName = new Dictionary<string, Entity>();

        public string InferredConnectionName { get; private set; }

        private void AssertSingleInferredConnectionName(string inferredConnectionName, string newConnection) {
            if (inferredConnectionName != null && inferredConnectionName != newConnection) {
                throw new InvalidOperationException("Cannot use more than one connection name in a SQL statement");
            }
        }


        public ContextualQueryParser(IEnumerable<Entity> entities) {
            foreach (var entity in entities) {
                entitiesByName.Add(entity.Name.ToLowerInvariant(), entity);
            }
        }


        public string Parse(string sql) {
            MatchCollection literals = SQL_LITERALS.Matches(sql);

            int pos = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Match literal in literals) {
                string before = sql.Substring(pos, literal.Index - pos);
                if (before != "") {
                    sb.Append(ParseNonLiteral(before));
                }

                sb.Append(literal.Value);

                pos = literal.Index + literal.Length;
            }

            string after = sql.Substring(pos);
            if (after != "") {
                sb.Append(ParseNonLiteral(after));
            }

            return sb.ToString();
        }

        private string ParseNonLiteral(string sql) {
            sql = ENTITY_STAR_REF.Replace(sql, new MatchEvaluator(ReplaceEntityStar));
            sql = ENTITY_ATTRIBUTE_REF.Replace(sql, new MatchEvaluator(ReplaceEntityAttribute));
            sql = ENTITY_REF.Replace(sql, new MatchEvaluator(ReplaceEntity));
            return sql;
        }



        private string ReplaceEntityStar(Match match) {
            string entityName = match.Groups[1].Value;

            Entity entity;
            if (entitiesByName.TryGetValue(entityName.ToLowerInvariant(), out entity)) {
                AssertSingleInferredConnectionName(InferredConnectionName, entity.ConnectionName);
                InferredConnectionName = entity.ConnectionName;

                StringBuilder sb = new StringBuilder();

                foreach (Entity.EntityAttribute attr in entity.Attributes) {
                    if (sb.Length != 0) {
                        sb.Append(", ");
                    }
                    sb.Append(SqlEscape(entity.TableName, entity.ConnectionName) + "." + SqlEscape(attr.Name, entity.ConnectionName));
                }

                return sb.ToString();
            }

            throw new InvalidOperationException("Could not resolve entity " + match.Value);
        }

        private string ReplaceEntityAttribute(Match match) {
            string entityName = match.Groups[1].Value;
            string attributeName = match.Groups[2].Value;

            Entity entity;
            if (entitiesByName.TryGetValue(entityName.ToLowerInvariant(), out entity)) {
                AssertSingleInferredConnectionName(InferredConnectionName, entity.ConnectionName);
                InferredConnectionName = entity.ConnectionName;

                foreach (Entity.EntityAttribute attr in entity.Attributes) {
                    if (attr.Name.ToLowerInvariant() == attributeName.ToLowerInvariant()) {
                        return SqlEscape(entity.TableName, entity.ConnectionName) + "." + SqlEscape(attr.Name, entity.ConnectionName);
                    }
                }
            }

            throw new InvalidOperationException("Could not resolve entity or attribute " + match.Value);
        }

        private string ReplaceEntity(Match match) {
            string entityName = match.Groups[1].Value;

            Entity entity;
            if (entitiesByName.TryGetValue(entityName.ToLowerInvariant(), out entity)) {
                AssertSingleInferredConnectionName(InferredConnectionName, entity.ConnectionName);
                InferredConnectionName = entity.ConnectionName;

                return SqlEscape(entity.TableName, entity.ConnectionName);
            }

            throw new InvalidOperationException("Could not resolve entity " + match.Value);
        }


        private string SqlEscape(string identifier, string connectionName) {
            DatabaseProvider provider;
            if (string.IsNullOrEmpty(connectionName)) {
                provider = DatabaseAccess.ForSystemDatabase();
            } else {
                provider = DatabaseAccess.ForExternalDatabase(connectionName);
            }

            return provider.SqlHelper.EscapeIdentifier(identifier);
        }
    }
}
