using Bank_System.Controller;
using Bank_System.Model;
using Bank_System.View;
using System;
using System.ComponentModel;

namespace Bank_System
{
    public partial class Login : Form
    {
        private LoginController loginController = new LoginController();

        public Login()
        {
            InitializeComponent();
           
        }

        // Handler event khi nhấn nút login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
        


            var user = new UserModel
            {
             
                Username = username,
                Password = password
            };

            

            try
            {
                if (loginController.ValidateLogin(user))
                {
                    MessageBox.Show("Login successfully!");
                    this.Hide();

                    // Lấy role của người dùng sau khi xác thực
                    string role = loginController.GetUserRole(username);

                    // Truyền username và role vào Homepage
                    Homepage home = new Homepage(username, role);
          
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Xử lý sự kiện validate username
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please input the username!");
                e.Cancel = true;
            }
            else if (txtUsername.Text.Length > 255)
            {
                MessageBox.Show("Username must not exceed 255 characters!");
                e.Cancel = true;
            }
            else if (!new EmployeeModel {name = txtUsername.Text }.IsValidUsername())
            {
                MessageBox.Show("The username should only be characters!");
                e.Cancel = true;
            }
        }

        // Xử lý sự kiện validate password
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input the password!");
                e.Cancel = true;
            }
        }
    }
}
