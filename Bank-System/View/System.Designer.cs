
using System.Windows.Forms;

namespace Bank_System.View
{
    partial class System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridViewBranch = new DataGridView();
            branchId = new DataGridViewTextBoxColumn();
            branchName = new DataGridViewTextBoxColumn();
            branchHouseNo = new DataGridViewTextBoxColumn();
            branchCity = new DataGridViewTextBoxColumn();
            tabBranch = new TabPage();
            panel2 = new Panel();
            txtCity = new TextBox();
            txtHouseNo = new TextBox();
            txtBranchName = new TextBox();
            txtBranchId = new TextBox();
            labelCity = new Label();
            btnCloseBranch = new Button();
            btnSaveBranch = new Button();
            labelHouseNo = new Label();
            btnDeleteBranch = new Button();
            labelBranch = new Label();
            labelBranchName = new Label();
            labelBranchId = new Label();
            tabEmployee = new TabPage();
            panel1 = new Panel();
            dataGridViewEm = new DataGridView();
            btnClose = new Button();
            btnSave = new Button();
            radioButtonUser = new RadioButton();
            radioButtonAdmin = new RadioButton();
            labelRight = new Label();
            txtPassword = new TextBox();
            txtEmployeeName = new TextBox();
            txtEmployeeId = new TextBox();
            labelPassword = new Label();
            btnDelete = new Button();
            labelEmployee = new Label();
            labelEmployeeName = new Label();
            labelEmployeeId = new Label();
            tabControl = new TabControl();
            EmployeeId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
           
            tabBranch.SuspendLayout();
            panel2.SuspendLayout();
            tabEmployee.SuspendLayout();
            panel1.SuspendLayout();
            
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBranch
            // 
            dataGridViewBranch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBranch.Columns.AddRange(new DataGridViewColumn[] { branchId, branchName, branchHouseNo, branchCity });
            dataGridViewBranch.Location = new Point(0, 0);
            dataGridViewBranch.Name = "dataGridViewBranch";
            dataGridViewBranch.RowHeadersWidth = 51;
            dataGridViewBranch.ScrollBars = ScrollBars.Vertical;
            dataGridViewBranch.Size = new Size(845, 398);
            dataGridViewBranch.TabIndex = 37;
            dataGridViewBranch.CellClick += dataGridViewBranch_CellClick;
            // 
            // branchId
            // 
            branchId.DataPropertyName = "id";
            branchId.HeaderText = "Branch ID";
            branchId.MinimumWidth = 6;
            branchId.Name = "branchId";
            branchId.ReadOnly = true;
            branchId.Width = 125;
            // 
            // branchName
            // 
            branchName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            branchName.DataPropertyName = "name";
            branchName.HeaderText = "Name";
            branchName.MinimumWidth = 6;
            branchName.Name = "branchName";
            // 
            // branchHouseNo
            // 
            branchHouseNo.DataPropertyName = "house_no";
            branchHouseNo.HeaderText = "House No";
            branchHouseNo.MinimumWidth = 6;
            branchHouseNo.Name = "branchHouseNo";
            branchHouseNo.Width = 125;
            // 
            // branchCity
            // 
            branchCity.DataPropertyName = "city";
            branchCity.HeaderText = "City";
            branchCity.MinimumWidth = 6;
            branchCity.Name = "branchCity";
            branchCity.Width = 125;
            // 
            // tabBranch
            // 
            tabBranch.Controls.Add(panel2);
            tabBranch.Controls.Add(txtCity);
            tabBranch.Controls.Add(txtHouseNo);
            tabBranch.Controls.Add(txtBranchName);
            tabBranch.Controls.Add(txtBranchId);
            tabBranch.Controls.Add(labelCity);
            tabBranch.Controls.Add(btnCloseBranch);
            tabBranch.Controls.Add(btnSaveBranch);
            tabBranch.Controls.Add(labelHouseNo);
            tabBranch.Controls.Add(btnDeleteBranch);
            tabBranch.Controls.Add(labelBranch);
            tabBranch.Controls.Add(labelBranchName);
            tabBranch.Controls.Add(labelBranchId);
            tabBranch.Location = new Point(4, 31);
            tabBranch.Name = "tabBranch";
            tabBranch.Padding = new Padding(3);
            tabBranch.Size = new Size(1912, 1045);
            tabBranch.TabIndex = 1;
            tabBranch.Text = "Branch";
            tabBranch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewBranch);
            panel2.Location = new Point(524, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 369);
            panel2.TabIndex = 52;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.MenuBar;
            txtCity.BorderStyle = BorderStyle.None;
            txtCity.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtCity.Location = new Point(750, 417);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(622, 33);
            txtCity.TabIndex = 51;
            // 
            // txtHouseNo
            // 
            txtHouseNo.BackColor = SystemColors.MenuBar;
            txtHouseNo.BorderStyle = BorderStyle.None;
            txtHouseNo.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtHouseNo.Location = new Point(750, 337);
            txtHouseNo.Name = "txtHouseNo";
            txtHouseNo.Size = new Size(622, 33);
            txtHouseNo.TabIndex = 46;
            // 
            // txtBranchName
            // 
            txtBranchName.BackColor = SystemColors.MenuBar;
            txtBranchName.BorderStyle = BorderStyle.None;
            txtBranchName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBranchName.Location = new Point(750, 256);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(622, 33);
            txtBranchName.TabIndex = 42;
            // 
            // txtBranchId
            // 
            txtBranchId.BackColor = SystemColors.MenuBar;
            txtBranchId.BorderStyle = BorderStyle.None;
            txtBranchId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBranchId.Location = new Point(750, 176);
            txtBranchId.Name = "txtBranchId";
            txtBranchId.Size = new Size(622, 33);
            txtBranchId.TabIndex = 41;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.Location = new Point(524, 420);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(64, 35);
            labelCity.TabIndex = 50;
            labelCity.Text = "City";
            // 
            // btnCloseBranch
            // 
            btnCloseBranch.BackColor = Color.Silver;
            btnCloseBranch.Font = new Font("Constantia", 13.8F);
            btnCloseBranch.ForeColor = SystemColors.ButtonHighlight;
            btnCloseBranch.Location = new Point(1279, 891);
            btnCloseBranch.Name = "btnCloseBranch";
            btnCloseBranch.Size = new Size(93, 38);
            btnCloseBranch.TabIndex = 49;
            btnCloseBranch.Text = "Close";
            btnCloseBranch.UseVisualStyleBackColor = false;
            btnCloseBranch.Click += btnCloseBranch_Click;
            // 
            // btnSaveBranch
            // 
            btnSaveBranch.BackColor = SystemColors.GradientActiveCaption;
            btnSaveBranch.Font = new Font("Constantia", 13.8F);
            btnSaveBranch.ForeColor = SystemColors.ActiveCaptionText;
            btnSaveBranch.Location = new Point(1167, 891);
            btnSaveBranch.Name = "btnSaveBranch";
            btnSaveBranch.Size = new Size(93, 38);
            btnSaveBranch.TabIndex = 48;
            btnSaveBranch.Text = "Save";
            btnSaveBranch.UseVisualStyleBackColor = false;
            btnSaveBranch.Click += btnSaveBranch_Click;
            btnSaveBranch.KeyDown += btnBranchEnter;
            // 
            // labelHouseNo
            // 
            labelHouseNo.AutoSize = true;
            labelHouseNo.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHouseNo.Location = new Point(524, 340);
            labelHouseNo.Name = "labelHouseNo";
            labelHouseNo.Size = new Size(139, 35);
            labelHouseNo.TabIndex = 45;
            labelHouseNo.Text = "House No.";
            // 
            // btnDeleteBranch
            // 
            btnDeleteBranch.BackColor = SystemColors.ButtonFace;
            btnDeleteBranch.Font = new Font("Constantia", 13.8F);
            btnDeleteBranch.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteBranch.Location = new Point(1059, 891);
            btnDeleteBranch.Name = "btnDeleteBranch";
            btnDeleteBranch.Size = new Size(93, 38);
            btnDeleteBranch.TabIndex = 44;
            btnDeleteBranch.Text = "Delete";
            btnDeleteBranch.UseVisualStyleBackColor = false;
            btnDeleteBranch.Click += btnDeleteBranch_Click;
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelBranch.Location = new Point(958, 79);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(145, 45);
            labelBranch.TabIndex = 43;
            labelBranch.Text = "Branch";
            labelBranch.Click += labelBranch_Click;
            // 
            // labelBranchName
            // 
            labelBranchName.AutoSize = true;
            labelBranchName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBranchName.Location = new Point(524, 259);
            labelBranchName.Name = "labelBranchName";
            labelBranchName.Size = new Size(178, 35);
            labelBranchName.TabIndex = 40;
            labelBranchName.Text = "Branch Name";
            // 
            // labelBranchId
            // 
            labelBranchId.AutoSize = true;
            labelBranchId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBranchId.Location = new Point(524, 179);
            labelBranchId.Name = "labelBranchId";
            labelBranchId.Size = new Size(139, 35);
            labelBranchId.TabIndex = 39;
            labelBranchId.Text = "Branch ID";
            // 
            // tabEmployee
            // 
            tabEmployee.AutoScroll = true;
            tabEmployee.Controls.Add(panel1);
            tabEmployee.Controls.Add(btnClose);
            tabEmployee.Controls.Add(btnSave);
            tabEmployee.Controls.Add(radioButtonUser);
            tabEmployee.Controls.Add(radioButtonAdmin);
            tabEmployee.Controls.Add(labelRight);
            tabEmployee.Controls.Add(txtPassword);
            tabEmployee.Controls.Add(txtEmployeeName);
            tabEmployee.Controls.Add(txtEmployeeId);
            tabEmployee.Controls.Add(labelPassword);
            tabEmployee.Controls.Add(btnDelete);
            tabEmployee.Controls.Add(labelEmployee);
            tabEmployee.Controls.Add(labelEmployeeName);
            tabEmployee.Controls.Add(labelEmployeeId);
            tabEmployee.Location = new Point(4, 31);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(1912, 1045);
            tabEmployee.TabIndex = 0;
            tabEmployee.Text = "Employee";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewEm);
            panel1.Location = new Point(520, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 379);
            panel1.TabIndex = 38;
            // 
            // dataGridViewEm
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEm.Columns.AddRange(new DataGridViewColumn[] { EmployeeId, Name, Password, Role });
            dataGridViewEm.Location = new Point(0, 0);
            dataGridViewEm.Name = "dataGridViewEm";
            dataGridViewEm.RowHeadersWidth = 51;
            dataGridViewEm.ScrollBars = ScrollBars.Vertical;
            dataGridViewEm.Size = new Size(848, 396);
            dataGridViewEm.TabIndex = 37;
            dataGridViewEm.CellClick += dataGridViewEm_CellClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.Font = new Font("Constantia", 13.8F);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(1275, 883);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(93, 38);
            btnClose.TabIndex = 36;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Constantia", 13.8F);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(1163, 883);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 38);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            btnSave.KeyDown += LoginButton_Enter;
            // 
            // radioButtonUser
            // 
            radioButtonUser.AccessibleRole = AccessibleRole.OutlineButton;
            radioButtonUser.AutoSize = true;
            radioButtonUser.Font = new Font("Constantia", 13.8F);
            radioButtonUser.Location = new Point(878, 429);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(79, 32);
            radioButtonUser.TabIndex = 33;
            radioButtonUser.TabStop = true;
            radioButtonUser.Text = "User";
            radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AccessibleRole = AccessibleRole.OutlineButton;
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Font = new Font("Constantia", 13.8F);
            radioButtonAdmin.Location = new Point(749, 429);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(102, 32);
            radioButtonAdmin.TabIndex = 32;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "Admin";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // labelRight
            // 
            labelRight.AutoSize = true;
            labelRight.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRight.Location = new Point(520, 426);
            labelRight.Name = "labelRight";
            labelRight.Size = new Size(69, 35);
            labelRight.TabIndex = 31;
            labelRight.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuBar;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(746, 344);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(622, 33);
            txtPassword.TabIndex = 30;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = SystemColors.MenuBar;
            txtEmployeeName.BorderStyle = BorderStyle.None;
            txtEmployeeName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmployeeName.Location = new Point(746, 263);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(622, 33);
            txtEmployeeName.TabIndex = 26;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.BackColor = SystemColors.MenuBar;
            txtEmployeeId.BorderStyle = BorderStyle.None;
            txtEmployeeId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmployeeId.Location = new Point(746, 183);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(622, 33);
            txtEmployeeId.TabIndex = 25;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(520, 347);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(128, 35);
            labelPassword.TabIndex = 29;
            labelPassword.Text = "Password";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Font = new Font("Constantia", 13.8F);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(1055, 883);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 38);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // labelEmployee
            // 
            labelEmployee.AutoSize = true;
            labelEmployee.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelEmployee.Location = new Point(922, 76);
            labelEmployee.Name = "labelEmployee";
            labelEmployee.Size = new Size(191, 45);
            labelEmployee.TabIndex = 27;
            labelEmployee.Text = "Employee";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmployeeName.Location = new Point(520, 266);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(208, 35);
            labelEmployeeName.TabIndex = 24;
            labelEmployeeName.Text = "Employee Name";
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.AutoSize = true;
            labelEmployeeId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmployeeId.Location = new Point(520, 186);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(169, 35);
            labelEmployeeId.TabIndex = 23;
            labelEmployeeId.Text = "Employee ID";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabEmployee);
            tabControl.Controls.Add(tabBranch);
            tabControl.Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            tabControl.Location = new Point(0, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1920, 1080);
            tabControl.TabIndex = 2;
            tabControl.KeyDown += CancelForm;
            // 
            // EmployeeId
            // 
            EmployeeId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            EmployeeId.DataPropertyName = "id";
            EmployeeId.HeaderText = "EmployeeId";
            EmployeeId.MinimumWidth = 6;
            EmployeeId.Name = "EmployeeId";
            EmployeeId.ReadOnly = true;
            EmployeeId.Width = 125;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Name.DataPropertyName = "username";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 411;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Password.DataPropertyName = "password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Role.DataPropertyName = "role";
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.Width = 135;
            // 
            // System
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
            StartPosition = FormStartPosition.Manual;
            Text = "System";
            WindowState = FormWindowState.Maximized;
            
            tabBranch.ResumeLayout(false);
            tabBranch.PerformLayout();
            panel2.ResumeLayout(false);
            tabEmployee.ResumeLayout(false);
            tabEmployee.PerformLayout();
            panel1.ResumeLayout(false);
           
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void labelBranch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private DataGridView dataGridViewBranch;

        #endregion

        private TabPage tabBranch;
        private TextBox txtCity;
        private TextBox txtHouseNo;
        private TextBox txtBranchName;
        private TextBox txtBranchId;
        private Label labelCity;
        private Button btnCloseBranch;
        private Button btnSaveBranch;
        private Label labelHouseNo;
        private Button btnDeleteBranch;
        private Label labelBranch;
        private Label labelBranchName;
        private Label labelBranchId;
        private TabPage tabEmployee;
        private Button btnClose;
        private Button btnSave;
        private RadioButton radioButtonUser;
        private RadioButton radioButtonAdmin;
        private Label labelRight;
        private TextBox txtPassword;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeId;
        private Label labelPassword;
        private Button btnDelete;
        private Label labelEmployee;
        private Label labelEmployeeName;
        private Label labelEmployeeId;
        private TabControl tabControl;
        private DataGridView dataGridViewEm;
        private Panel panel1;
        private DataGridViewTextBoxColumn branchId;
        private DataGridViewTextBoxColumn branchName;
        private DataGridViewTextBoxColumn branchHouseNo;
        private DataGridViewTextBoxColumn branchCity;
        private Panel panel2;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
    }
}