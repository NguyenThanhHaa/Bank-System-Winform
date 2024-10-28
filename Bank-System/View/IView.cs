using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.View
{
    internal interface IView
    {
        public void ShowMessage(string message, string title, MessageBoxIcon icon);
        public Boolean CheckTextStatus(Dictionary<TextBox, string> fields);
        
    }
}
