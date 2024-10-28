namespace Bank_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtPassword = new MaskedTextBox();
            btnLogin = new Button();
            labelLogin = new Label();
            txtUsername = new TextBox();
            labelPassword = new Label();
            labelUsername = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(labelLogin);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1898, 1027);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = SystemColors.MenuBar;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(817, 558);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(414, 33);
            txtPassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.Font = new Font("Constantia", 10.2F);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(956, 670);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 52);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelLogin.Location = new Point(956, 298);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(119, 45);
            labelLogin.TabIndex = 5;
            labelLogin.Text = "Login";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuBar;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.Location = new Point(817, 426);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(414, 33);
            txtUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(640, 558);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(128, 35);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(640, 424);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(136, 35);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            ShowInTaskbar = false;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsername;
        private Label labelPassword;
        private Label labelUsername;
        private Button btnLogin;
        private Label labelLogin;
        private MaskedTextBox txtPassword;
    }
}
