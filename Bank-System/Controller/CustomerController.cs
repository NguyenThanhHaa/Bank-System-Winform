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
    internal class CustomerController : IController
    {
        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public CustomerController()
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

        //Thêm mới customer 
        public bool Create(IModel model)
        {
            var customerModel = model as CustomerModel;


            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO CUSTOMER (id,name,phone,email, house_no, city,pin) VALUES (@id, @name,@phone,@email, @house_no, @city, @pin)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", customerModel.id);
                cmd.Parameters.AddWithValue("@name", customerModel.name);
                cmd.Parameters.AddWithValue("@phone", customerModel.phone);
                cmd.Parameters.AddWithValue("@email", customerModel.email);
                cmd.Parameters.AddWithValue("@house_no", customerModel.house_no);
                cmd.Parameters.AddWithValue("@city", customerModel.city);
                cmd.Parameters.AddWithValue("@pin", customerModel.pin);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        //Xóa customer
        public bool Delete(object id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM CUSTOMER WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool IsExist(string branchId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", branchId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();  // Trả về số lượng kết quả (COUNT)
                return count > 0;  // Trả về true nếu CustomerId đã tồn tại
            }
        }

        //Load dữ liệu từ csdl lên 
        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM CUSTOMER";
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

        // Cập nhật thông tin customer
        public bool Update(IModel model)
        {
            var customerModel = model as CustomerModel;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE CUSTOMER SET name = @name, phone=@phone, email=@email, house_no = @house_no, city = @city, pin=@pin WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", customerModel.id);
                cmd.Parameters.AddWithValue("@name", customerModel.name);
                cmd.Parameters.AddWithValue("@phone", customerModel.phone);
                cmd.Parameters.AddWithValue("@email", customerModel.email);
                cmd.Parameters.AddWithValue("@house_no", customerModel.house_no);
                cmd.Parameters.AddWithValue("@city", customerModel.city);
                cmd.Parameters.AddWithValue("@pin", customerModel.pin);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
