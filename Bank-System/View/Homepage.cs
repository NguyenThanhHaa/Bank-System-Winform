using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bank_System.View
{
    public partial class Homepage : Form
    {
        private string _username;
        private string _role;

        public Homepage(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            lblUserName.Text = $"{_username}";
            loginToolStripMenuItem.Visible = false;

            // Kiểm tra quyền của người dùng để ẩn các mục nếu không phải là Admin
            if (_role != "Admin")
            {
                employeeToolStripMenuItem.Enabled = false;
                branchToolStripMenuItem.Enabled = false;
            }
        }

        private void Check_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.panelHome.Visible = true;
        }

        private void OpenSystemForm(string selectedTab)
        {
            // Kiểm tra quyền Admin trước khi mở form System
            if (_role != "Admin" && (selectedTab == "Employee" || selectedTab == "Branch"))
            {
                MessageBox.Show("Access Denied: Admins only");
                return;
            }

            System systemForm = new System();
            systemForm.MdiParent = this;
            systemForm.SelectedTab = selectedTab; // Set tab tương ứng

            this.panelHome.Hide();
            systemForm.Show();

            if (selectedTab == "Employee")
            {
                systemForm.FormClosed += new FormClosedEventHandler(Check_FormClosed);
            }
            else if (selectedTab == "Branch")
            {
                systemForm.FormClosed += new FormClosedEventHandler(Check_FormClosed);
            }
        }

        private void branchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSystemForm("Branch");
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSystemForm("Employee");
        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banking banking = new Banking();
            banking.MdiParent = this;
            banking.SelectedTab = "Create Customer";
            this.panelHome.Hide();
            banking.Show();
            banking.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banking banking = new Banking();
            banking.MdiParent = this;
            banking.SelectedTab = "Create Account";
            this.panelHome.Hide();
            banking.Show();
            banking.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        

        private void transactionAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banking banking = new Banking();
            banking.MdiParent = this;
            banking.SelectedTab = "Transaction Amount";
            this.panelHome.Hide();
            banking.Show();
            banking.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        private void balanceAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banking banking = new Banking();
            banking.MdiParent = this;
            banking.SelectedTab = "Balance Account";
            this.panelHome.Hide();
            banking.Show();
            banking.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        private void transactionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banking banking = new Banking();
            banking.MdiParent = this;
            banking.SelectedTab = "Transaction Log";
            this.panelHome.Hide();
            banking.Show();
            banking.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.MdiParent = this;
            helpForm.SelectedTab = "About";
            this.panelHome.Hide();
            helpForm.Show();
            helpForm.FormClosed += new FormClosedEventHandler(Check_FormClosed);
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.MdiParent = this;
            this.panelHome.Visible = false;
            loginForm.Show();
        }

        private void linkLabelUserGuide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help userGuide = new Help();
            userGuide.MdiParent = this;
            userGuide.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.MdiParent = this;
            this.panelHome.Visible = false;
            loginForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
