using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1.DB
{
    public class DbMethods
    {
        public static void InsertToDb(string cred, string sql)
        {
            DbConnectOracle connect = new DbConnectOracle();
            connect.GetConnection().ConnectionString = cred;
            connect.OpenConnection();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = connect.GetConnection();
            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery()/*.ExecuteReader()*/;
            }
            catch (Exception ex)
            {
                Print.PrintToLog(ex.Message);
            }

            connect.CloseConnection();
        }
    }
}
