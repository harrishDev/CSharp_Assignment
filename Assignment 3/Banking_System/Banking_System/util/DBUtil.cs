using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Banking_System.util
{
    public class DBUtil
    {
        public static SqlConnection GetConnection()
        {
            string connStr = "Server=DESKTOP-HNVF699;Database=HMBank;TrustServerCertificate=True;Integrated Security=True;";
            return new SqlConnection(connStr);
        }
    }
}