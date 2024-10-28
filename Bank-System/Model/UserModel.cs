using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System.Model
{
    internal class UserModel : IModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsValidPassword()
        {
            return !string.IsNullOrEmpty(Password);
        }

        public bool IsValidUsername()
        {
            if (string.IsNullOrEmpty(Username) || Username.Length > 255 || !IsUsernameLettersOnly())
            {
                return false;
            }
            return true;
        }

        // Kiểm tra username chỉ chứa ký tự chữ cái
        private bool IsUsernameLettersOnly()
        {
            foreach (char c in Username)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
