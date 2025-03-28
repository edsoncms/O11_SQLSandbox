using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;
using OutSystems.NssSQLCMD.Connections;
using System.Diagnostics;
using OutSystems.NssSQLCMD.Parser;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.IO;
using System.Text;
using OutSystems.RuntimeCommon;
using System.Data.SqlClient;

namespace OutSystems.NssSQLCMD {

	public class CssSQLCMD: IssSQLCMD {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssSQL">SQL Statement(s)</param>
        /// <param name="ssTypeList">Statement Type</param>
        public void MssGetStatementType(string ssSQL, out RLTypeRecordList ssTypeList)
        {
            ssTypeList = new RLTypeRecordList();

            RCTypeRecord rcTypeRecord = new RCTypeRecord();

            TextReader rdr = new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(ssSQL)));
            TSql110Parser parser = new TSql110Parser(true);

            IList<ParseError> errors;

            StatementList statementList = parser.ParseStatementList(rdr, out errors);

            if (errors.Count == 0)
            {
                foreach (TSqlStatement statement in statementList.Statements)
                {
                    if (statement is SelectStatement)
                    {
                        rcTypeRecord.ssSTType.ssName = "SelectStatement";
                        rcTypeRecord.ssSTType.ssIsValidForSelectRole = true;
                        rcTypeRecord.ssSTType.ssIsValidForDMLRole = true;
                        ssTypeList.Append(rcTypeRecord);
                    }
                    else if (statement is UpdateStatement)
                    {
                        rcTypeRecord.ssSTType.ssName = "UpdateStatement";
                        rcTypeRecord.ssSTType.ssIsValidForSelectRole = false;
                        rcTypeRecord.ssSTType.ssIsValidForDMLRole = true;
                        ssTypeList.Append(rcTypeRecord);
                    }
                    else if (statement is InsertStatement)
                    {
                        rcTypeRecord.ssSTType.ssName = "InsertStatement";
                        rcTypeRecord.ssSTType.ssIsValidForSelectRole = false;
                        rcTypeRecord.ssSTType.ssIsValidForDMLRole = true;
                        ssTypeList.Append(rcTypeRecord);
                    }
                    else if (statement is DeleteStatement)
                    {
                        rcTypeRecord.ssSTType.ssName = "DeleteStatement";
                        rcTypeRecord.ssSTType.ssIsValidForSelectRole = false;
                        rcTypeRecord.ssSTType.ssIsValidForDMLRole = true;
                        ssTypeList.Append(rcTypeRecord);
                    }
                    else
                    {
                        rcTypeRecord.ssSTType.ssName = "Other";
                        rcTypeRecord.ssSTType.ssIsValidForSelectRole = false;
                        rcTypeRecord.ssSTType.ssIsValidForDMLRole = false;
                        ssTypeList.Append(rcTypeRecord);
                    }

                }
            }
            else
            {
                rcTypeRecord.ssSTType.ssName = "Error";
                rcTypeRecord.ssSTType.ssIsValidForSelectRole = true;
                rcTypeRecord.ssSTType.ssIsValidForDMLRole = true;
                ssTypeList.Append(rcTypeRecord);
            }
        } // MssGetStatementType




        public void MssExecute(string ssSQL, long ssMaxRecords, string ssCatalogName, string ssConnectionName, bool ssRollbackTransaction, out RLColumnRecordList ssColumns, out RLRowRecordList ssRows, out long ssCount, out long ssAffectedRows, bool ssIncludeMessage, out string ssMessage, bool ssShowXML, out string ssXMLSQLPlan) {


            ssMessage = "";
            ssXMLSQLPlan = "";

            //using (connection) {


            if (ssIncludeMessage || ssShowXML)
            {
                using (var connection = GetConnectionByName(ssCatalogName, ssConnectionName))
                {
                    SqlConnection sqlCon = (SqlConnection)connection.trans.GetConnection().GetDriverConnection();
                    var messageWrapper = new SqlInfoMessageWrapper(sqlCon);
                    sqlCon.FireInfoMessageEventOnUserErrors = true;

                    var cmd = connection.trans.CreateCommand();
                    if (ssShowXML)
                    {


                        //Enable the statistics.
                        cmd.CommandText = "SET STATISTICS XML ON";
                        cmd.ExecuteNonQuery();

                        //Run through the query, keeping the first row first column of the last result set.
                        cmd.CommandText = ssSQL;
                        using (var reader = cmd.ExecuteReader())
                        {
                            object lastValue = null;
                            do
                            {
                                if (reader.Read())
                                {
                                    lastValue = reader.GetValue(0);
                                }
                            } while (reader.NextResult());

                            if (lastValue != null)
                            {
                                ssXMLSQLPlan = lastValue as string;
                            }
                        }

                    }

                    if (ssIncludeMessage)
                    {
                        cmd.CommandText = ssSQL;
                        cmd.CommandTimeout = 0;
                        cmd.ExecuteNonQuery();

                        ssMessage = messageWrapper.Message;
                    }

                }
            }

            using (var connection = GetConnectionByName(ssCatalogName, ssConnectionName))
            {
                if (ssCatalogName != "")
                    ssSQL = "use [" + ssCatalogName + "] " + ssSQL;
                ResultSet resultSet = new ResultSet(connection, ssSQL, ssMaxRecords);
                ssColumns = resultSet.GetColumns();
                ssRows = resultSet.GetRows();
                ssCount = resultSet.TotalRows;
                ssAffectedRows = resultSet.AffectedRows;



                if (ssRollbackTransaction)
                {
                    connection.Rollback();
                }
                else
                {
                    connection.Commit();
                }
            }


         

        }

		public void MssIsProduction(out bool ssIsProduction) {
			ssIsProduction = (AppInfo.GetAppInfo().ServerMode == ServerModes.Production);
		}


        public void MssParseContextualQuery(string ssContextualSQL, RLEntityDetailsRecordList ssContext, out string ssSQL, out bool ssHasInferredConnectionName, out string ssInferredConnectionName, out bool ssHasInferredOutput, out RLEntityAttributeDetailsRecordList ssInferredOutput) {
            ContextualQueryParser parser = new ContextualQueryParser(Entity.FromRecordList(ssContext));
            ssSQL = parser.Parse(ssContextualSQL);

            ssHasInferredConnectionName = parser.InferredConnectionName != null;
            ssInferredConnectionName = parser.InferredConnectionName ?? string.Empty;
			ssHasInferredOutput = false;
			ssInferredOutput = new RLEntityAttributeDetailsRecordList();
		}




        private AbstractConnection GetConnectionByName(string catalog, string connection) {
            if (string.IsNullOrEmpty(catalog) && string.IsNullOrEmpty(connection)) {
                return new RuntimeConnection(DatabaseAccess.ForRunningApplication());
            } else if (!string.IsNullOrEmpty(catalog)) {
                switch (catalog) {
#if VOID_WARRANTY
                    case "(Main+DDL)":
                        return new AdminConnection();
#endif
                    default:
                        return new RuntimeConnection(DatabaseAccess.ForDatabase(catalog));
                }
            } else {
                return new RuntimeConnection(DatabaseAccess.ForExternalDatabase(connection));
            }
        }



        
		public void MssStartTimer(out object ssTimer) {
			Stopwatch timer = new Stopwatch();
            timer.Start();
            ssTimer = timer;
		}

		public void MssStopTimer(object ssTimer, out long ssMilliseconds) {
            Stopwatch timer = (Stopwatch) ssTimer;
            timer.Stop();
			ssMilliseconds = timer.ElapsedMilliseconds;
		}

    }

}

