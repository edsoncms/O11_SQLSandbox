using System;
using System.Data.SqlClient;

namespace OutSystems.NssSQLCMD
{
    public class SqlInfoMessageWrapper
    {
        public SqlInfoMessageWrapper(SqlConnection connection)
        {
            SqlConnection = connection;
            connection.InfoMessage += new SqlInfoMessageEventHandler(InfoMessageHandler);
        }
        public SqlConnection SqlConnection { get; set; }
        public string Message { get; set; }

        void InfoMessageHandler(object sender, SqlInfoMessageEventArgs e)
        {
            Message += e.Message + Environment.NewLine;
        }
    }
}
