using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1.DB
{
    public static class DbCredentials
    {
        public static string credOraTest = "Data Source=(DESCRIPTION ="
                                    + "(ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.173)(PORT = 1521))"
                                    + "(CONNECT_DATA =" + "(SERVER = DEDICATED)"
                                    + "(SERVICE_NAME = orcl)));"
                                    + "User Id=scott;Password=tiger;";
    }
}
