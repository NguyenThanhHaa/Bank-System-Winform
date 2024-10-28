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
    internal class LoginController : IController
    {
        private DatabaseHelper DatabaseHelper;

        public LoginController()
        {
            this.DatabaseHelper = new DatabaseHelper();
        }

        public bool Update(IModel model)
        {
            throw new NotImplementedException();
        }


        // Hàm kiểm tra đăng nhập
        public bool ValidateLogin(UserModel user)
        {
            if (!user.IsValidUsername())
            {
                throw new ArgumentException("Username is not valid.");
            }

            if (!user.IsValidPassword())
            {
                throw new ArgumentException("Password is not valid.");
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT password FROM EMPLOYEE WHERE username=@username"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.Username);

                conn.Open();
                var storedHashedPassword = cmd.ExecuteScalar() as string;

                if (storedHashedPassword != null)
                {
                    // Kiểm tra mật khẩu nhập vào có khớp với mật khẩu đã mã hóa
                    return BCrypt.Net.BCrypt.Verify(user.Password, storedHashedPassword);

                }
                else
                {
                    return false;
                }


            }
        }

        //Lấy role của user
        public string GetUserRole(string username)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT role FROM EMPLOYEE WHERE username=@username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username); 
                conn.Open();

                return cmd.ExecuteScalar() as string;
            }
        }



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
    }
}
