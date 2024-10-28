using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System.View
{
    public partial class Help : Form
    {
        public string SelectedTab { get; set; }
        public Help()
        {
            InitializeComponent();
            this.Load += new EventHandler(HelpForm_Load);
        }

       private void HelpForm_Load(object sender, EventArgs e)
        {
            if(SelectedTab == "User Guide")
            {
                tabHelp.SelectedTab = tabUserGuide;
            }
            else if (SelectedTab == "About")
            {
                 tabHelp.SelectedTab= tabAbout;
            }
        }
    }
}
