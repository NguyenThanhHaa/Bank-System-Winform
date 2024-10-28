using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Bank_System.Model;

namespace Bank_System.Utils
{
    public class DatabaseHelper
    {
        private readonly string connectionString = "Data Source=AVOCADOE;Initial Catalog=BANKSYSTEM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
