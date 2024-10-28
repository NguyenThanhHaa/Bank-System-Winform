using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Model
{
    internal class AccountModel : IModel
    {
        public int id { get; set; }
        public string customerid { get; set; }
        public DateOnly date_opened { get; set; }
        public float balance { get; set; }
        public string pin { get; set; }


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
