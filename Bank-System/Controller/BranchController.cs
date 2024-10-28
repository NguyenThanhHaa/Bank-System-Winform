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
    internal class BranchController : IController
    {
        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public BranchController()
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

        // Thêm mới branch
        public bool Create(IModel model)
        {
            var branchModel = model as BranchModel;


            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO BRANCH (id,name, house_no, city) VALUES (@id, @name, @house_no, @city)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", branchModel.id);
                cmd.Parameters.AddWithValue("@name", branchModel.name);
                cmd.Parameters.AddWithValue("@house_no", branchModel.house_no);
                cmd.Parameters.AddWithValue("@city", branchModel.city);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Xóa branch
        public bool Delete(object id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM BRANCH WHERE id = @id";
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
                string query = "SELECT COUNT(*) FROM BRANCH WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", branchId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();  // Trả về số lượng kết quả (COUNT)
                return count > 0;  // Trả về true nếu BranchId đã tồn tại
            }
        }

        //Load dữ liệu từ csdl lên 
        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM BRANCH";
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

        // Cập nhật thông tin branch
        public bool Update(IModel model)
        {
            var branchModel = model as BranchModel;
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "UPDATE BRANCH SET name = @name, house_no = @house_no, city = @city WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", branchModel.id);
                cmd.Parameters.AddWithValue("@name", branchModel.name);
                cmd.Parameters.AddWithValue("@house_no", branchModel.house_no);
                cmd.Parameters.AddWithValue("@city", branchModel.city);


                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}
