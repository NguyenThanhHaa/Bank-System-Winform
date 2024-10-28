namespace Bank_System.View
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private void InitializeComponent()
        {
            tabHelp = new TabControl();
            tabUserGuide = new TabPage();
            tabAbout = new TabPage();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label6 = new Label();
            linkLabelUserGuide = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            linkLabelLogin = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            tabHelp.SuspendLayout();
            tabAbout.SuspendLayout();
           
            SuspendLayout();
            // 
            // tabHelp
            // 
            tabHelp.Controls.Add(tabUserGuide);
            tabHelp.Controls.Add(tabAbout);
            tabHelp.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tabHelp.Location = new Point(2, 2);
            tabHelp.Name = "tabHelp";
            tabHelp.SelectedIndex = 0;
            tabHelp.Size = new Size(1920, 1080);
            tabHelp.TabIndex = 0;
            // 
            // tabUserGuide
            // 
            tabUserGuide.Location = new Point(4, 31);
            tabUserGuide.Name = "tabUserGuide";
            tabUserGuide.Padding = new Padding(3);
            tabUserGuide.Size = new Size(1912, 1045);
            tabUserGuide.TabIndex = 0;
            tabUserGuide.Text = "User Guide";
            tabUserGuide.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            tabAbout.BackColor = Color.White;
            tabAbout.BackgroundImageLayout = ImageLayout.Center;
            tabAbout.Controls.Add(pictureBox1);
            tabAbout.Controls.Add(label1);
            tabAbout.Controls.Add(label6);
            tabAbout.Controls.Add(linkLabelUserGuide);
            tabAbout.Controls.Add(label5);
            tabAbout.Controls.Add(label4);
            tabAbout.Controls.Add(linkLabelLogin);
            tabAbout.Controls.Add(label3);
            tabAbout.Controls.Add(label2);
            tabAbout.Location = new Point(4, 31);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(1912, 1045);
            tabAbout.TabIndex = 1;
            tabAbout.Text = "About";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ff0686b5804958309d89010c3eaa05cb;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(688, 339);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 348);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(854, 714);
            label1.Name = "label1";
            label1.Size = new Size(256, 22);
            label1.TabIndex = 8;
            label1.Text = "Your energy is my currency ;)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(819, 283);
            label6.Name = "label6";
            label6.Size = new Size(472, 22);
            label6.TabIndex = 7;
            label6.Text = "will help you how to use this system in case you need :)";
            // 
            // linkLabelUserGuide
            // 
            linkLabelUserGuide.AutoSize = true;
            linkLabelUserGuide.Location = new Point(726, 283);
            linkLabelUserGuide.Name = "linkLabelUserGuide";
            linkLabelUserGuide.Size = new Size(104, 22);
            linkLabelUserGuide.TabIndex = 6;
            linkLabelUserGuide.TabStop = true;
            linkLabelUserGuide.Text = "User Guide";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(688, 283);
            label5.Name = "label5";
            label5.Size = new Size(42, 22);
            label5.TabIndex = 5;
            label5.Text = "The";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(933, 241);
            label4.Name = "label4";
            label4.Size = new Size(212, 22);
            label4.TabIndex = 4;
            label4.Text = "before using the system";
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.Location = new Point(882, 241);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(59, 22);
            linkLabelLogin.TabIndex = 3;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(819, 241);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 2;
            label3.Text = "Please";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(668, 152);
            label2.Name = "label2";
            label2.Size = new Size(620, 45);
            label2.TabIndex = 1;
            label2.Text = "WELCOME TO THE BANK SYSTEM";
            // 
            // Help
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(tabHelp);
            Name = "Help";
            Text = "Help";
            WindowState = FormWindowState.Maximized;
            tabHelp.ResumeLayout(false);
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
          
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private TabControl tabHelp;
        private TabPage tabUserGuide;
        private TabPage tabAbout;
        private Label label4;
        private LinkLabel linkLabelLogin;
        private Label label3;
        private Label label2;
        private Label label6;
        private LinkLabel linkLabelUserGuide;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
    }
}