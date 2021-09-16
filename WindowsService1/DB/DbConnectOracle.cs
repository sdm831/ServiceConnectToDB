using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1.DB
{
    public class DbConnectOracle
    {
        OracleConnection oraConnect = new OracleConnection();

        public void OpenConnection()
        {
            try
            {
                if (oraConnect.State == System.Data.ConnectionState.Closed)
                {
                    oraConnect.Open();
                }
            }
            catch (Exception ex)
            {
                Print.PrintToLog(ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (oraConnect.State == System.Data.ConnectionState.Open)
                {
                    oraConnect.Close();
                }
            }
            catch (Exception ex)
            {
                Print.PrintToLog(ex.Message);
            }
        }

        public OracleConnection GetConnection()
        {
            return oraConnect;
        }
    }
}
