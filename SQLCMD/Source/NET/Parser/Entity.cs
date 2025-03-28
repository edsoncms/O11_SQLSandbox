using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssSQLCMD.Parser {
    public class Entity {

        public readonly string Name;
        public readonly string TableName;
        public readonly string ConnectionName;

        public readonly List<EntityAttribute> Attributes = new List<EntityAttribute>();


        public Entity(string name, string tableName, string connectionName) {
            this.Name = name;
            this.TableName = tableName;
            this.ConnectionName = connectionName;
        }

        public void AddAttribute(EntityAttribute attribute) {
            this.Attributes.Add(attribute);
        }


        public static IList<Entity> FromRecordList(RLEntityDetailsRecordList recordList) {
            recordList.StartIteration();
            try {
                IList<Entity> result = new List<Entity>();

                while (!recordList.Eof) {
                    Entity entity = new Entity(recordList.CurrentRec.ssSTEntityDetails.ssName, recordList.CurrentRec.ssSTEntityDetails.ssPhysicalTableName, recordList.CurrentRec.ssSTEntityDetails.ssLogicalConnection);
                    
                    recordList.CurrentRec.ssSTEntityDetails.ssAttributes.StartIteration();
                    try {
                        while (!recordList.CurrentRec.ssSTEntityDetails.ssAttributes.Eof) {
                            EntityAttribute attr = new EntityAttribute(recordList.CurrentRec.ssSTEntityDetails.ssAttributes.CurrentRec.ssSTEntityAttributeDetails.ssName, recordList.CurrentRec.ssSTEntityDetails.ssAttributes.CurrentRec.ssSTEntityAttributeDetails.ssType);
                            entity.AddAttribute(attr);

                            recordList.CurrentRec.ssSTEntityDetails.ssAttributes.Advance();
                        }
                    } finally {
                        recordList.CurrentRec.ssSTEntityDetails.ssAttributes.EndIteration();
                    }

                    result.Add(entity);
                    recordList.Advance();
                }

                return result;

            } finally {
                recordList.EndIteration();
            }
        }



        public class EntityAttribute {
            public readonly string Name;
            public readonly string Type;

            public EntityAttribute(string name, string type) {
                this.Name = name;
                this.Type = type;
            }
        }
    }
}
