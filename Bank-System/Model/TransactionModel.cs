using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Model
{
    internal class TransactionModel : IModel
    {
        public string id { get; set; }
        public int from_account_id { get; set; }
        public string branch_id { get; set; }
        public DateTime date_of_trans { get; set; }
        public float amount { get; set; }
        public string pin  { get; set; }
        public int to_account_id { get; set; }
        public string employee_id { get; set; }

        public string trans_type { get; set; }



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
