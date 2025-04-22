using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Project.util
{
    public class DBConnUtil
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=DESKTOP-HNVF699;Database=SISDB;Trusted_Connection=True;TrustServerCertificate=True;";
            return new SqlConnection(connectionString); // Ensure System.Data.SqlClient is installed via NuGet
        }
    }
}
