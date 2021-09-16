using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsService1.DB;

namespace WindowsService1
{
    public class Inserter
    {
        bool enabled = true;
        string sql;

        public void Start()
        {
            while (enabled)
            {
                sql = $"insert into scott.service (value) VALUES ('{DateTime.Now}')";
                DbMethods.InsertToDb(DbCredentials.credOraTest, sql);
                Thread.Sleep(16000);
            }
        }
        public void Stop()
        {
            enabled = false;
        }
    }
}
