using OutSystems.RuntimePublic.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace OutSystems.NssSQLCMD.Connections {
    public class ResultSet {

        private readonly long maxRecords;
        private long totalRows;
        private long affectedRows;
        private string[] columns;
        private List<object[]> allValues = new List<object[]>();

        public ResultSet(AbstractConnection connection, string sql, long maxRecords) {
            this.maxRecords = maxRecords;

            using (Command cmd = connection.trans.CreateCommand(sql)) {
                cmd.CommandTimeout = 0;
                using (IDataReader reader = cmd.ExecuteReader()) {
                    Read(reader);
                }
            }
        }

        private void Read(IDataReader reader) {
            affectedRows = reader.RecordsAffected;

            columns = new string[reader.FieldCount];
            for (int i = 0; i < reader.FieldCount; i++) {
                columns[i] = reader.GetName(i);
            }

            long j = 0;
            while (reader.Read()) {
                if (maxRecords == 0 || j++ < maxRecords) {
                    object[] row = new object[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++) {
                        row[i] = reader.GetValue(i);
                    }

                    allValues.Add(row);
                }
            }

            totalRows = j;
        }

        public RLColumnRecordList GetColumns() {
            RLColumnRecordList result = new RLColumnRecordList();

            for (int i = 0; i < columns.Length; i++) {
                RCColumnRecord column = new RCColumnRecord(null);
                column.ssSTColumn.ssAlias = columns[i];
                result.Append(column);
            }

            return result;
        }

        public RLRowRecordList GetRows() {
            RLRowRecordList rows = new RLRowRecordList();

            foreach (object[] values in allValues) {
                RCRowRecord row = new RCRowRecord(null);

                for (int i = 0; i < values.Length; i++) {
                    object value = values[i];

                    RCRowValueRecord rowValue = new RCRowValueRecord(null);
                    rowValue.ssSTRowValue.ssColumnName = columns[i];

                    if (value is DBNull) {
                        rowValue.ssSTRowValue.ssIsNull = true;
                    } else if (value is DateTime) {
                        rowValue.ssSTRowValue.ssIsDateTime = true;
                        rowValue.ssSTRowValue.ssDateTimeValue = (DateTime) value;
                    } else if (value is byte[]) {
                        rowValue.ssSTRowValue.ssIsBinary = true;
                        rowValue.ssSTRowValue.ssBinaryValue = (byte[]) value;
                    } else {
                        rowValue.ssSTRowValue.ssTextValue = Convert.ToString(value);
                    }

                    row.ssSTRow.ssValues.Append(rowValue);
                }

                rows.Append(row);
            }

            return rows;
        }

        public long TotalRows { get { return totalRows; } }

        public long AffectedRows { get { return affectedRows; } }
    }
}
