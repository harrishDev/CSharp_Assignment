using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Shop.Util
{
    public static class DBConnUtil
    {
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection("Server=DESKTOP-HNVF699;Database=TechShop;TrustServerCertificate=True;Integrated Security=True;");
            conn.Open(); // Ensure the connection is opened
            return conn;
        }
    }
}