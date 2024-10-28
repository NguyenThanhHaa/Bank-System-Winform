using Bank_System.Model;
using Bank_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Controller
{
    internal class DepositController : IController
    {
        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public DepositController()
        {
            this.items = new List<IModel>();
            this.DatabaseHelper = new DatabaseHelper();
        }

        public List<IModel> Items
        {
            get
            {
                return this.items;
            }
        }

        //Thêm mới giao dịch nạp tiền 
        public bool Create(IModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(string id)
        {
            throw new NotImplementedException();
        }

        public DataTable Load()
        {
            throw new NotImplementedException();
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
