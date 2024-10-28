using Bank_System.Model;
using Bank_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Controller
{
    internal class AccountController : IController
    {

        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public AccountController()
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

        //Thêm mới account 
        public bool Create(IModel model)
        {
            var accountModel = model as AccountModel;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO ACCOUNT (customerid, date_opened, balance) VALUES (@customerid, @date_opened, @balance)";
                SqlCommand cmd = new SqlCommand(query, conn);

                //cmd.Parameters.AddWithValue("@id", accountModel.id);
                cmd.Parameters.AddWithValue("@customerid", accountModel.customerid);

                // Chuyển đổi DateOnly thành DateTime trước khi thêm vào SQL
                cmd.Parameters.AddWithValue("@date_opened", accountModel.date_opened.ToDateTime(TimeOnly.MinValue));

                cmd.Parameters.AddWithValue("@balance", accountModel.balance);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Xóa account
        public bool Delete(object id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM ACCOUNT WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool IsExist(int accountId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM ACCOUNT WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", accountId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();  // Trả về số lượng kết quả (COUNT)
                return count > 0;  // Trả về true nếu BranchId đã tồn tại
            }
        }

        public bool IsExist(string id)
        {
            throw new NotImplementedException();
        }

        //Load dữ liệu từ csdl lên 
        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM ACCOUNT";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable); // Fill DataTable with query result
            }
            return dataTable;
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        // Cập nhật thông tin account
        public bool Update(IModel model)
        {
            var accountModel = model as AccountModel;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE ACCOUNT SET customerid = @customerid, date_opened = @date_opened WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", accountModel.id);
                cmd.Parameters.AddWithValue("@customerid", accountModel.customerid);
                cmd.Parameters.AddWithValue("@date_opened", accountModel.date_opened.ToDateTime(TimeOnly.MinValue));
                cmd.Parameters.AddWithValue("@balance", accountModel.balance);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
