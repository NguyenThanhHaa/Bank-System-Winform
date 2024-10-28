using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Model
{
    internal class EmployeeModel : IModel
    {
        public string id { get; set; }  
        public string name { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public bool IsValidPassword()
        {
            throw new NotImplementedException();
        }

        public bool IsValidUsername()
        {
            throw new NotImplementedException();
        }
    }
}

