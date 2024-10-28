namespace Bank_System.View
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            branchToolStripMenuItem = new ToolStripMenuItem();
            bankingToolStripMenuItem = new ToolStripMenuItem();
            createCustomerToolStripMenuItem = new ToolStripMenuItem();
            createAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionAmountToolStripMenuItem = new ToolStripMenuItem();
            balanceAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionLogToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem1 = new ToolStripMenuItem();
            panelHome = new Panel();
            lblUserName = new Label();
            labelHome = new Label();
            label1 = new Label();
            label6 = new Label();
            linkLabelUserGuide = new LinkLabel();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem, bankingToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(1902, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 26);
            fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(149, 26);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(149, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { employeeToolStripMenuItem, branchToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(80, 26);
            systemToolStripMenuItem.Text = "System";
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 26);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // branchToolStripMenuItem
            // 
            branchToolStripMenuItem.Name = "branchToolStripMenuItem";
            branchToolStripMenuItem.Size = new Size(224, 26);
            branchToolStripMenuItem.Text = "Branch";
            branchToolStripMenuItem.Click += branchToolStripMenuItem_Click;
            // 
            // bankingToolStripMenuItem
            // 
            bankingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createCustomerToolStripMenuItem, createAccountToolStripMenuItem, transactionAmountToolStripMenuItem, balanceAccountToolStripMenuItem, transactionLogToolStripMenuItem });
            bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
            bankingToolStripMenuItem.Size = new Size(88, 26);
            bankingToolStripMenuItem.Text = "Banking";
            // 
            // createCustomerToolStripMenuItem
            // 
            createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            createCustomerToolStripMenuItem.Size = new Size(254, 26);
            createCustomerToolStripMenuItem.Text = "Create Customer";
            createCustomerToolStripMenuItem.Click += createCustomerToolStripMenuItem_Click;
            // 
            // createAccountToolStripMenuItem
            // 
            createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            createAccountToolStripMenuItem.Size = new Size(254, 26);
            createAccountToolStripMenuItem.Text = "Create Account";
            createAccountToolStripMenuItem.Click += createAccountToolStripMenuItem_Click;
            // 
            // transactionAmountToolStripMenuItem
            // 
            transactionAmountToolStripMenuItem.Name = "transactionAmountToolStripMenuItem";
            transactionAmountToolStripMenuItem.Size = new Size(254, 26);
            transactionAmountToolStripMenuItem.Text = "Transaction Amount";
            transactionAmountToolStripMenuItem.Click += transactionAmountToolStripMenuItem_Click;
            // 
            // balanceAccountToolStripMenuItem
            // 
            balanceAccountToolStripMenuItem.Name = "balanceAccountToolStripMenuItem";
            balanceAccountToolStripMenuItem.Size = new Size(254, 26);
            balanceAccountToolStripMenuItem.Text = "Balance Account";
            balanceAccountToolStripMenuItem.Click += balanceAccountToolStripMenuItem_Click;
            // 
            // transactionLogToolStripMenuItem
            // 
            transactionLogToolStripMenuItem.Name = "transactionLogToolStripMenuItem";
            transactionLogToolStripMenuItem.Size = new Size(254, 26);
            transactionLogToolStripMenuItem.Text = "Transaction Log";
            transactionLogToolStripMenuItem.Click += transactionLogToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, helpToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(62, 26);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(181, 26);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // helpToolStripMenuItem1
            // 
            helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            helpToolStripMenuItem1.Size = new Size(181, 26);
            helpToolStripMenuItem1.Text = "About";
            helpToolStripMenuItem1.Click += helpToolStripMenuItem1_Click;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.White;
            panelHome.BackgroundImage = Properties.Resources.ff0686b5804958309d89010c3eaa05cb;
            panelHome.BackgroundImageLayout = ImageLayout.Center;
            panelHome.Controls.Add(lblUserName);
            panelHome.Controls.Add(labelHome);
            panelHome.Controls.Add(label1);
            panelHome.Controls.Add(label6);
            panelHome.Controls.Add(linkLabelUserGuide);
            panelHome.Controls.Add(label5);
            panelHome.Location = new Point(0, 33);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(2055, 1153);
            panelHome.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Constantia", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 163);
            lblUserName.ForeColor = Color.Blue;
            lblUserName.Location = new Point(1040, 247);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(199, 45);
            lblUserName.TabIndex = 17;
            lblUserName.Text = "Username";
            // 
            // labelHome
            // 
            labelHome.AutoSize = true;
            labelHome.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelHome.Location = new Point(837, 247);
            labelHome.Name = "labelHome";
            labelHome.Size = new Size(210, 45);
            labelHome.TabIndex = 16;
            labelHome.Text = "WELCOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(900, 384);
            label1.Name = "label1";
            label1.Size = new Size(241, 22);
            label1.TabIndex = 15;
            label1.Text = "Your energy is my currency ;)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(881, 320);
            label6.Name = "label6";
            label6.Size = new Size(443, 22);
            label6.TabIndex = 14;
            label6.Text = "will help you how to use this system in case you need :)";
            // 
            // linkLabelUserGuide
            // 
            linkLabelUserGuide.AutoSize = true;
            linkLabelUserGuide.Location = new Point(788, 320);
            linkLabelUserGuide.Name = "linkLabelUserGuide";
            linkLabelUserGuide.Size = new Size(97, 22);
            linkLabelUserGuide.TabIndex = 13;
            linkLabelUserGuide.TabStop = true;
            linkLabelUserGuide.Text = "User Guide";
            linkLabelUserGuide.LinkClicked += linkLabelUserGuide_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 320);
            label5.Name = "label5";
            label5.Size = new Size(40, 22);
            label5.TabIndex = 12;
            label5.Text = "The";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelHome);
            Controls.Add(menuStrip1);
            Font = new Font("Constantia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem branchToolStripMenuItem;
        private ToolStripMenuItem bankingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem createCustomerToolStripMenuItem;
        private ToolStripMenuItem createAccountToolStripMenuItem;
        private ToolStripMenuItem transactionAmountToolStripMenuItem;
        private ToolStripMenuItem balanceAccountToolStripMenuItem;
        private ToolStripMenuItem transactionLogToolStripMenuItem;
        private Panel panelHome;
        private Label label6;
        private LinkLabel linkLabelUserGuide;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label labelUser;
        private Label labelHome;
        private Label lblUserName;
    }
}