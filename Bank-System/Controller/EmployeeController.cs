using Bank_System.Model;
using Bank_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bank_System.Controller
{
    internal class EmployeeController : IController
    {
        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public EmployeeController()
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

        // Load dữ liệu từ cơ sở dữ liệu vào DataTable
        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable); // Fill DataTable with query result
            }
            return dataTable;
        }

        // Thêm mới nhân viên
        public bool Create(IModel model)
        {
            var employeeModel = model as EmployeeModel;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(employeeModel.password);


            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO EMPLOYEE (id,username, password, role) VALUES (@id, @username, @password, @role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeModel.id); 
                cmd.Parameters.AddWithValue("@username", employeeModel.name);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@role", employeeModel.role);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


        // Xóa nhân viên
        public bool Delete(object id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM EMPLOYEE WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Cập nhật thông tin nhân viên
        public bool Update(IModel model)
        {
            var EmployeeModel = model as EmployeeModel;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE EMPLOYEE SET username = @username, password = @password, role = @role WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", EmployeeModel.id);
                cmd.Parameters.AddWithValue("@username", EmployeeModel.name);
                cmd.Parameters.AddWithValue("@password", EmployeeModel.password);
                cmd.Parameters.AddWithValue("@role", EmployeeModel.role);
                

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool IsExist(string employeeId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();  // Trả về số lượng kết quả (COUNT)
                return count > 0;  // Trả về true nếu EmployeeId đã tồn tại
            }
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        
       

        
    }
}
