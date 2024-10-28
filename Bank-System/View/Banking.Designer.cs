using System.Windows.Forms;

namespace Bank_System.View
{
    partial class Banking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabTransLog = new TabPage();
            dataGridViewTransLog = new DataGridView();
            labelTransLog = new Label();
            tabBalance = new TabPage();
            txtBalanceAmount = new TextBox();
            txtBalancePin = new TextBox();
            txtBalanceBranchId = new TextBox();
            txtBalanceAccId = new TextBox();
            labelBalanceAmount = new Label();
            btnBalanceCancel = new Button();
            btnBalanceCheck = new Button();
            labelBalancePin = new Label();
            labelBalanceBranchId = new Label();
            labelBalanceAcc = new Label();
            labelBalanceAccId = new Label();
            tabTrans = new TabPage();
            panel3 = new Panel();
            dataGridViewTrans = new DataGridView();
            transId = new DataGridViewTextBoxColumn();
            fromAccId = new DataGridViewTextBoxColumn();
            toAccId = new DataGridViewTextBoxColumn();
            transAmount = new DataGridViewTextBoxColumn();
            transType = new DataGridViewTextBoxColumn();
            transBranchId = new DataGridViewTextBoxColumn();
            transDate = new DataGridViewTextBoxColumn();
            transPin = new DataGridViewTextBoxColumn();
            transemId = new DataGridViewTextBoxColumn();
            label2 = new Label();
            radioTrans = new RadioButton();
            radioWithdraw = new RadioButton();
            radioDeposit = new RadioButton();
            btnTransCancel = new Button();
            btnTransSave = new Button();
            txtTransPin = new TextBox();
            txtTransEmId = new TextBox();
            txtTransAmount = new TextBox();
            txtTransToAccId = new TextBox();
            txtTransBranchId = new TextBox();
            txtFromAccId = new TextBox();
            labelTransPin = new Label();
            dateTimePickerTrans = new DateTimePicker();
            labelTransEmId = new Label();
            labelTransAmount = new Label();
            labelTransToAccId = new Label();
            labelDateOfTrans = new Label();
            labelTrans = new Label();
            labelTransBranchId = new Label();
            labelTransFromAccId = new Label();
            tabAccount = new TabPage();
            txtAccId = new TextBox();
            txtAccBalance = new TextBox();
            txtCusID = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            dataGridViewAccount = new DataGridView();
            accountId = new DataGridViewTextBoxColumn();
            accCusId = new DataGridViewTextBoxColumn();
            accountDateOpened = new DataGridViewTextBoxColumn();
            accountBalance = new DataGridViewTextBoxColumn();
            dateTimePickerAcc = new DateTimePicker();
            btnCAClose = new Button();
            btnCASave = new Button();
            labelBalance = new Label();
            btnCADel = new Button();
            labelAccount = new Label();
            labelDateOpened = new Label();
            labelCusID = new Label();
            tabCustomer = new TabPage();
            txtCustomerId = new TextBox();
            txtCusPin = new TextBox();
            txtCusCity = new TextBox();
            txtCusHouseNo = new TextBox();
            txtCusEmail = new TextBox();
            txtCusPhone = new TextBox();
            txtCusName = new TextBox();
            labelCustomerId = new Label();
            panel1 = new Panel();
            dataGridViewCus = new DataGridView();
            customerId = new DataGridViewTextBoxColumn();
            customerName = new DataGridViewTextBoxColumn();
            customerPhone = new DataGridViewTextBoxColumn();
            customerEmail = new DataGridViewTextBoxColumn();
            customerHouseNo = new DataGridViewTextBoxColumn();
            customerCity = new DataGridViewTextBoxColumn();
            customerPin = new DataGridViewTextBoxColumn();
            labelPin = new Label();
            labelCity = new Label();
            labelCusHouseNo = new Label();
            btnCCClose = new Button();
            btnCCSave = new Button();
            labelCusEmail = new Label();
            btnCCDelete = new Button();
            labelCustomer = new Label();
            labelCusPhone = new Label();
            labelCusName = new Label();
            tabControl = new TabControl();
            tabTransLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransLog).BeginInit();
            tabBalance.SuspendLayout();
            tabTrans.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrans).BeginInit();
            tabAccount.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            tabCustomer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCus).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabTransLog
            // 
            tabTransLog.Controls.Add(dataGridViewTransLog);
            tabTransLog.Controls.Add(labelTransLog);
            tabTransLog.Location = new Point(4, 29);
            tabTransLog.Name = "tabTransLog";
            tabTransLog.Padding = new Padding(3);
            tabTransLog.Size = new Size(1912, 1047);
            tabTransLog.TabIndex = 6;
            tabTransLog.Text = "Transaction Log";
            tabTransLog.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTransLog
            // 
            dataGridViewTransLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransLog.Location = new Point(529, 267);
            dataGridViewTransLog.Name = "dataGridViewTransLog";
            dataGridViewTransLog.RowHeadersWidth = 51;
            dataGridViewTransLog.Size = new Size(727, 371);
            dataGridViewTransLog.TabIndex = 106;
            // 
            // labelTransLog
            // 
            labelTransLog.AutoSize = true;
            labelTransLog.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTransLog.Location = new Point(747, 159);
            labelTransLog.Name = "labelTransLog";
            labelTransLog.Size = new Size(298, 45);
            labelTransLog.TabIndex = 105;
            labelTransLog.Text = "Transaction Log";
            // 
            // tabBalance
            // 
            tabBalance.Controls.Add(txtBalanceAmount);
            tabBalance.Controls.Add(txtBalancePin);
            tabBalance.Controls.Add(txtBalanceBranchId);
            tabBalance.Controls.Add(txtBalanceAccId);
            tabBalance.Controls.Add(labelBalanceAmount);
            tabBalance.Controls.Add(btnBalanceCancel);
            tabBalance.Controls.Add(btnBalanceCheck);
            tabBalance.Controls.Add(labelBalancePin);
            tabBalance.Controls.Add(labelBalanceBranchId);
            tabBalance.Controls.Add(labelBalanceAcc);
            tabBalance.Controls.Add(labelBalanceAccId);
            tabBalance.Location = new Point(4, 31);
            tabBalance.Name = "tabBalance";
            tabBalance.Padding = new Padding(3);
            tabBalance.Size = new Size(1912, 1045);
            tabBalance.TabIndex = 5;
            tabBalance.Text = "Balance Account";
            tabBalance.UseVisualStyleBackColor = true;
            // 
            // txtBalanceAmount
            // 
            txtBalanceAmount.BackColor = SystemColors.MenuBar;
            txtBalanceAmount.BorderStyle = BorderStyle.None;
            txtBalanceAmount.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBalanceAmount.Location = new Point(829, 594);
            txtBalanceAmount.Multiline = true;
            txtBalanceAmount.Name = "txtBalanceAmount";
            txtBalanceAmount.Size = new Size(439, 35);
            txtBalanceAmount.TabIndex = 115;
            // 
            // txtBalancePin
            // 
            txtBalancePin.BackColor = SystemColors.MenuBar;
            txtBalancePin.BorderStyle = BorderStyle.None;
            txtBalancePin.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBalancePin.Location = new Point(829, 505);
            txtBalancePin.Multiline = true;
            txtBalancePin.Name = "txtBalancePin";
            txtBalancePin.Size = new Size(439, 35);
            txtBalancePin.TabIndex = 111;
            // 
            // txtBalanceBranchId
            // 
            txtBalanceBranchId.BackColor = SystemColors.MenuBar;
            txtBalanceBranchId.BorderStyle = BorderStyle.None;
            txtBalanceBranchId.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBalanceBranchId.Location = new Point(829, 402);
            txtBalanceBranchId.Multiline = true;
            txtBalanceBranchId.Name = "txtBalanceBranchId";
            txtBalanceBranchId.Size = new Size(439, 35);
            txtBalanceBranchId.TabIndex = 109;
            // 
            // txtBalanceAccId
            // 
            txtBalanceAccId.BackColor = SystemColors.MenuBar;
            txtBalanceAccId.BorderStyle = BorderStyle.None;
            txtBalanceAccId.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBalanceAccId.Location = new Point(829, 309);
            txtBalanceAccId.Multiline = true;
            txtBalanceAccId.Name = "txtBalanceAccId";
            txtBalanceAccId.Size = new Size(439, 35);
            txtBalanceAccId.TabIndex = 103;
            // 
            // labelBalanceAmount
            // 
            labelBalanceAmount.AutoSize = true;
            labelBalanceAmount.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalanceAmount.Location = new Point(591, 594);
            labelBalanceAmount.Name = "labelBalanceAmount";
            labelBalanceAmount.Size = new Size(213, 35);
            labelBalanceAmount.TabIndex = 114;
            labelBalanceAmount.Text = "Balance Amount";
            // 
            // btnBalanceCancel
            // 
            btnBalanceCancel.BackColor = SystemColors.ControlDark;
            btnBalanceCancel.Font = new Font("Constantia", 13.8F);
            btnBalanceCancel.ForeColor = Color.Black;
            btnBalanceCancel.Location = new Point(1164, 697);
            btnBalanceCancel.Name = "btnBalanceCancel";
            btnBalanceCancel.Size = new Size(104, 46);
            btnBalanceCancel.TabIndex = 113;
            btnBalanceCancel.Text = "Cancel";
            btnBalanceCancel.UseVisualStyleBackColor = false;
            // 
            // btnBalanceCheck
            // 
            btnBalanceCheck.BackColor = SystemColors.GradientInactiveCaption;
            btnBalanceCheck.Font = new Font("Constantia", 13.8F);
            btnBalanceCheck.ForeColor = Color.Black;
            btnBalanceCheck.Location = new Point(829, 697);
            btnBalanceCheck.Name = "btnBalanceCheck";
            btnBalanceCheck.Size = new Size(122, 46);
            btnBalanceCheck.TabIndex = 112;
            btnBalanceCheck.Text = "Check";
            btnBalanceCheck.UseVisualStyleBackColor = false;
            // 
            // labelBalancePin
            // 
            labelBalancePin.AutoSize = true;
            labelBalancePin.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalancePin.Location = new Point(591, 508);
            labelBalancePin.Name = "labelBalancePin";
            labelBalancePin.Size = new Size(61, 35);
            labelBalancePin.TabIndex = 110;
            labelBalancePin.Text = "PIN";
            // 
            // labelBalanceBranchId
            // 
            labelBalanceBranchId.AutoSize = true;
            labelBalanceBranchId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalanceBranchId.Location = new Point(591, 405);
            labelBalanceBranchId.Name = "labelBalanceBranchId";
            labelBalanceBranchId.Size = new Size(139, 35);
            labelBalanceBranchId.TabIndex = 108;
            labelBalanceBranchId.Text = "Branch ID";
            // 
            // labelBalanceAcc
            // 
            labelBalanceAcc.AutoSize = true;
            labelBalanceAcc.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelBalanceAcc.Location = new Point(829, 167);
            labelBalanceAcc.Name = "labelBalanceAcc";
            labelBalanceAcc.Size = new Size(306, 45);
            labelBalanceAcc.TabIndex = 104;
            labelBalanceAcc.Text = "Balance Account";
            // 
            // labelBalanceAccId
            // 
            labelBalanceAccId.AutoSize = true;
            labelBalanceAccId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalanceAccId.Location = new Point(591, 312);
            labelBalanceAccId.Name = "labelBalanceAccId";
            labelBalanceAccId.Size = new Size(152, 35);
            labelBalanceAccId.TabIndex = 101;
            labelBalanceAccId.Text = "Account ID";
            // 
            // tabTrans
            // 
            tabTrans.Controls.Add(panel3);
            tabTrans.Controls.Add(label2);
            tabTrans.Controls.Add(radioTrans);
            tabTrans.Controls.Add(radioWithdraw);
            tabTrans.Controls.Add(radioDeposit);
            tabTrans.Controls.Add(btnTransCancel);
            tabTrans.Controls.Add(btnTransSave);
            tabTrans.Controls.Add(txtTransPin);
            tabTrans.Controls.Add(txtTransEmId);
            tabTrans.Controls.Add(txtTransAmount);
            tabTrans.Controls.Add(txtTransToAccId);
            tabTrans.Controls.Add(txtTransBranchId);
            tabTrans.Controls.Add(txtFromAccId);
            tabTrans.Controls.Add(labelTransPin);
            tabTrans.Controls.Add(dateTimePickerTrans);
            tabTrans.Controls.Add(labelTransEmId);
            tabTrans.Controls.Add(labelTransAmount);
            tabTrans.Controls.Add(labelTransToAccId);
            tabTrans.Controls.Add(labelDateOfTrans);
            tabTrans.Controls.Add(labelTrans);
            tabTrans.Controls.Add(labelTransBranchId);
            tabTrans.Controls.Add(labelTransFromAccId);
            tabTrans.Location = new Point(4, 31);
            tabTrans.Name = "tabTrans";
            tabTrans.Padding = new Padding(3);
            tabTrans.Size = new Size(1912, 1045);
            tabTrans.TabIndex = 4;
            tabTrans.Text = "Transaction Amount";
            tabTrans.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewTrans);
            panel3.Location = new Point(308, 491);
            panel3.Name = "panel3";
            panel3.Size = new Size(1306, 342);
            panel3.TabIndex = 107;
            // 
            // dataGridViewTrans
            // 
            dataGridViewTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTrans.Columns.AddRange(new DataGridViewColumn[] { transId, fromAccId, toAccId, transAmount, transType, transBranchId, transDate, transPin, transemId });
            dataGridViewTrans.Location = new Point(0, 0);
            dataGridViewTrans.Name = "dataGridViewTrans";
            dataGridViewTrans.RowHeadersWidth = 51;
            dataGridViewTrans.Size = new Size(1306, 391);
            dataGridViewTrans.TabIndex = 0;
            // 
            // transId
            // 
            transId.DataPropertyName = "id";
            transId.HeaderText = "ID";
            transId.MinimumWidth = 6;
            transId.Name = "transId";
            transId.Width = 125;
            // 
            // fromAccId
            // 
            fromAccId.DataPropertyName = "from_account_id";
            fromAccId.HeaderText = "From";
            fromAccId.MinimumWidth = 6;
            fromAccId.Name = "fromAccId";
            fromAccId.Width = 150;
            // 
            // toAccId
            // 
            toAccId.DataPropertyName = "to_account_id";
            toAccId.HeaderText = "To";
            toAccId.MinimumWidth = 6;
            toAccId.Name = "toAccId";
            toAccId.Width = 150;
            // 
            // transAmount
            // 
            transAmount.DataPropertyName = "amount";
            transAmount.HeaderText = "Amount";
            transAmount.MinimumWidth = 6;
            transAmount.Name = "transAmount";
            transAmount.Width = 165;
            // 
            // transType
            // 
            transType.DataPropertyName = "trans_type";
            transType.HeaderText = "Type";
            transType.MinimumWidth = 6;
            transType.Name = "transType";
            transType.Width = 150;
            // 
            // transBranchId
            // 
            transBranchId.DataPropertyName = "branch_id";
            transBranchId.HeaderText = "Branch ID";
            transBranchId.MinimumWidth = 6;
            transBranchId.Name = "transBranchId";
            transBranchId.Width = 110;
            // 
            // transDate
            // 
            transDate.DataPropertyName = "date_of_trans";
            transDate.HeaderText = "Date";
            transDate.MinimumWidth = 6;
            transDate.Name = "transDate";
            transDate.Width = 160;
            // 
            // transPin
            // 
            transPin.DataPropertyName = "pin";
            transPin.HeaderText = "PIN";
            transPin.MinimumWidth = 6;
            transPin.Name = "transPin";
            transPin.Width = 150;
            // 
            // transemId
            // 
            transemId.DataPropertyName = "employee_id";
            transemId.HeaderText = "Employee ID";
            transemId.MinimumWidth = 6;
            transemId.Name = "transemId";
            transemId.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1038, 394);
            label2.Name = "label2";
            label2.Size = new Size(72, 35);
            label2.TabIndex = 106;
            label2.Text = "Type";
            // 
            // radioTrans
            // 
            radioTrans.AutoSize = true;
            radioTrans.Font = new Font("Constantia", 12F);
            radioTrans.Location = new Point(1534, 401);
            radioTrans.Name = "radioTrans";
            radioTrans.Size = new Size(80, 28);
            radioTrans.TabIndex = 105;
            radioTrans.TabStop = true;
            radioTrans.Text = "Trans";
            radioTrans.UseVisualStyleBackColor = true;
            // 
            // radioWithdraw
            // 
            radioWithdraw.AutoSize = true;
            radioWithdraw.Font = new Font("Constantia", 12F);
            radioWithdraw.Location = new Point(1373, 401);
            radioWithdraw.Name = "radioWithdraw";
            radioWithdraw.Size = new Size(120, 28);
            radioWithdraw.TabIndex = 104;
            radioWithdraw.TabStop = true;
            radioWithdraw.Text = "Withdraw";
            radioWithdraw.UseVisualStyleBackColor = true;
            // 
            // radioDeposit
            // 
            radioDeposit.AutoSize = true;
            radioDeposit.Font = new Font("Constantia", 12F);
            radioDeposit.Location = new Point(1240, 401);
            radioDeposit.Name = "radioDeposit";
            radioDeposit.Size = new Size(99, 28);
            radioDeposit.TabIndex = 103;
            radioDeposit.TabStop = true;
            radioDeposit.Text = "Deposit";
            radioDeposit.UseVisualStyleBackColor = true;
            // 
            // btnTransCancel
            // 
            btnTransCancel.BackColor = SystemColors.ControlDark;
            btnTransCancel.Font = new Font("Constantia", 13.8F);
            btnTransCancel.ForeColor = Color.Black;
            btnTransCancel.Location = new Point(1510, 880);
            btnTransCancel.Name = "btnTransCancel";
            btnTransCancel.Size = new Size(104, 46);
            btnTransCancel.TabIndex = 102;
            btnTransCancel.Text = "Close";
            btnTransCancel.UseVisualStyleBackColor = false;
            // 
            // btnTransSave
            // 
            btnTransSave.BackColor = SystemColors.GradientInactiveCaption;
            btnTransSave.Font = new Font("Constantia", 13.8F);
            btnTransSave.ForeColor = Color.Black;
            btnTransSave.Location = new Point(1352, 880);
            btnTransSave.Name = "btnTransSave";
            btnTransSave.Size = new Size(100, 46);
            btnTransSave.TabIndex = 101;
            btnTransSave.Text = "Save";
            btnTransSave.UseVisualStyleBackColor = false;
            btnTransSave.Click += btnTransSave_Click;
            // 
            // txtTransPin
            // 
            txtTransPin.BackColor = SystemColors.MenuBar;
            txtTransPin.BorderStyle = BorderStyle.None;
            txtTransPin.Font = new Font("Constantia", 16.2F);
            txtTransPin.Location = new Point(548, 394);
            txtTransPin.Name = "txtTransPin";
            txtTransPin.Size = new Size(382, 33);
            txtTransPin.TabIndex = 72;
            // 
            // txtTransEmId
            // 
            txtTransEmId.BackColor = SystemColors.MenuBar;
            txtTransEmId.BorderStyle = BorderStyle.None;
            txtTransEmId.Font = new Font("Constantia", 16.2F);
            txtTransEmId.Location = new Point(1240, 314);
            txtTransEmId.Name = "txtTransEmId";
            txtTransEmId.Size = new Size(378, 33);
            txtTransEmId.TabIndex = 69;
            // 
            // txtTransAmount
            // 
            txtTransAmount.BackColor = SystemColors.MenuBar;
            txtTransAmount.BorderStyle = BorderStyle.None;
            txtTransAmount.Font = new Font("Constantia", 16.2F);
            txtTransAmount.Location = new Point(1240, 232);
            txtTransAmount.Name = "txtTransAmount";
            txtTransAmount.Size = new Size(378, 33);
            txtTransAmount.TabIndex = 67;
            // 
            // txtTransToAccId
            // 
            txtTransToAccId.BackColor = SystemColors.MenuBar;
            txtTransToAccId.BorderStyle = BorderStyle.None;
            txtTransToAccId.Font = new Font("Constantia", 16.2F);
            txtTransToAccId.Location = new Point(1240, 150);
            txtTransToAccId.Name = "txtTransToAccId";
            txtTransToAccId.Size = new Size(378, 33);
            txtTransToAccId.TabIndex = 65;
            // 
            // txtTransBranchId
            // 
            txtTransBranchId.BackColor = SystemColors.MenuBar;
            txtTransBranchId.BorderStyle = BorderStyle.None;
            txtTransBranchId.Font = new Font("Constantia", 16.2F);
            txtTransBranchId.Location = new Point(548, 233);
            txtTransBranchId.Name = "txtTransBranchId";
            txtTransBranchId.Size = new Size(382, 33);
            txtTransBranchId.TabIndex = 60;
            // 
            // txtFromAccId
            // 
            txtFromAccId.BackColor = SystemColors.MenuBar;
            txtFromAccId.BorderStyle = BorderStyle.None;
            txtFromAccId.Font = new Font("Constantia", 16.2F);
            txtFromAccId.Location = new Point(548, 153);
            txtFromAccId.Name = "txtFromAccId";
            txtFromAccId.Size = new Size(382, 33);
            txtFromAccId.TabIndex = 59;
            // 
            // labelTransPin
            // 
            labelTransPin.AutoSize = true;
            labelTransPin.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransPin.Location = new Point(308, 394);
            labelTransPin.Name = "labelTransPin";
            labelTransPin.Size = new Size(61, 35);
            labelTransPin.TabIndex = 71;
            labelTransPin.Text = "PIN";
            // 
            // dateTimePickerTrans
            // 
            dateTimePickerTrans.Location = new Point(548, 311);
            dateTimePickerTrans.Name = "dateTimePickerTrans";
            dateTimePickerTrans.Size = new Size(382, 29);
            dateTimePickerTrans.TabIndex = 70;
            // 
            // labelTransEmId
            // 
            labelTransEmId.AutoSize = true;
            labelTransEmId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransEmId.Location = new Point(1038, 315);
            labelTransEmId.Name = "labelTransEmId";
            labelTransEmId.Size = new Size(169, 35);
            labelTransEmId.TabIndex = 68;
            labelTransEmId.Text = "Employee ID";
            // 
            // labelTransAmount
            // 
            labelTransAmount.AutoSize = true;
            labelTransAmount.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransAmount.Location = new Point(1038, 233);
            labelTransAmount.Name = "labelTransAmount";
            labelTransAmount.Size = new Size(115, 35);
            labelTransAmount.TabIndex = 66;
            labelTransAmount.Text = "Amount";
            // 
            // labelTransToAccId
            // 
            labelTransToAccId.AutoSize = true;
            labelTransToAccId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransToAccId.Location = new Point(1038, 151);
            labelTransToAccId.Name = "labelTransToAccId";
            labelTransToAccId.Size = new Size(188, 35);
            labelTransToAccId.TabIndex = 64;
            labelTransToAccId.Text = "To Account ID";
            // 
            // labelDateOfTrans
            // 
            labelDateOfTrans.AutoSize = true;
            labelDateOfTrans.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateOfTrans.Location = new Point(308, 314);
            labelDateOfTrans.Name = "labelDateOfTrans";
            labelDateOfTrans.Size = new Size(174, 35);
            labelDateOfTrans.TabIndex = 62;
            labelDateOfTrans.Text = "Date of Trans";
            // 
            // labelTrans
            // 
            labelTrans.AutoSize = true;
            labelTrans.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTrans.Location = new Point(830, 48);
            labelTrans.Name = "labelTrans";
            labelTrans.Size = new Size(377, 45);
            labelTrans.TabIndex = 61;
            labelTrans.Text = "Transaction Amount";
            // 
            // labelTransBranchId
            // 
            labelTransBranchId.AutoSize = true;
            labelTransBranchId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransBranchId.Location = new Point(308, 233);
            labelTransBranchId.Name = "labelTransBranchId";
            labelTransBranchId.Size = new Size(139, 35);
            labelTransBranchId.TabIndex = 58;
            labelTransBranchId.Text = "Branch ID";
            // 
            // labelTransFromAccId
            // 
            labelTransFromAccId.AutoSize = true;
            labelTransFromAccId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTransFromAccId.Location = new Point(308, 153);
            labelTransFromAccId.Name = "labelTransFromAccId";
            labelTransFromAccId.Size = new Size(223, 35);
            labelTransFromAccId.TabIndex = 57;
            labelTransFromAccId.Text = "From Account ID";
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(txtAccId);
            tabAccount.Controls.Add(txtAccBalance);
            tabAccount.Controls.Add(txtCusID);
            tabAccount.Controls.Add(label3);
            tabAccount.Controls.Add(panel2);
            tabAccount.Controls.Add(dateTimePickerAcc);
            tabAccount.Controls.Add(btnCAClose);
            tabAccount.Controls.Add(btnCASave);
            tabAccount.Controls.Add(labelBalance);
            tabAccount.Controls.Add(btnCADel);
            tabAccount.Controls.Add(labelAccount);
            tabAccount.Controls.Add(labelDateOpened);
            tabAccount.Controls.Add(labelCusID);
            tabAccount.Location = new Point(4, 29);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3);
            tabAccount.Size = new Size(1912, 1047);
            tabAccount.TabIndex = 1;
            tabAccount.Text = "Create Account";
            tabAccount.UseVisualStyleBackColor = true;
            // 
            // txtAccId
            // 
            txtAccId.BackColor = SystemColors.MenuBar;
            txtAccId.BorderStyle = BorderStyle.None;
            txtAccId.Font = new Font("Constantia", 16.2F);
            txtAccId.Location = new Point(771, 156);
            txtAccId.Name = "txtAccId";
            txtAccId.Size = new Size(622, 33);
            txtAccId.TabIndex = 73;
            // 
            // txtAccBalance
            // 
            txtAccBalance.BackColor = SystemColors.MenuBar;
            txtAccBalance.BorderStyle = BorderStyle.None;
            txtAccBalance.Font = new Font("Constantia", 16.2F);
            txtAccBalance.Location = new Point(771, 391);
            txtAccBalance.Name = "txtAccBalance";
            txtAccBalance.Size = new Size(622, 33);
            txtAccBalance.TabIndex = 64;
            // 
            // txtCusID
            // 
            txtCusID.BackColor = SystemColors.MenuBar;
            txtCusID.BorderStyle = BorderStyle.None;
            txtCusID.Font = new Font("Constantia", 16.2F);
            txtCusID.Location = new Point(771, 230);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(622, 33);
            txtCusID.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(545, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 35);
            label3.TabIndex = 72;
            label3.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewAccount);
            panel2.Location = new Point(548, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(848, 389);
            panel2.TabIndex = 71;
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Columns.AddRange(new DataGridViewColumn[] { accountId, accCusId, accountDateOpened, accountBalance });
            dataGridViewAccount.Location = new Point(0, 3);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.RowHeadersWidth = 51;
            dataGridViewAccount.Size = new Size(845, 451);
            dataGridViewAccount.TabIndex = 37;
            dataGridViewAccount.CellClick += datagridViewAccount_Click;
            // 
            // accountId
            // 
            accountId.DataPropertyName = "id";
            accountId.HeaderText = "ID";
            accountId.MinimumWidth = 6;
            accountId.Name = "accountId";
            accountId.ReadOnly = true;
            accountId.Width = 125;
            // 
            // accCusId
            // 
            accCusId.DataPropertyName = "customerid";
            accCusId.HeaderText = "Customer ID ";
            accCusId.MinimumWidth = 6;
            accCusId.Name = "accCusId";
            accCusId.ReadOnly = true;
            accCusId.Width = 175;
            // 
            // accountDateOpened
            // 
            accountDateOpened.DataPropertyName = "date_opened";
            accountDateOpened.HeaderText = "Date Opened";
            accountDateOpened.MinimumWidth = 6;
            accountDateOpened.Name = "accountDateOpened";
            accountDateOpened.Width = 175;
            // 
            // accountBalance
            // 
            accountBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            accountBalance.DataPropertyName = "balance";
            accountBalance.HeaderText = "Balance";
            accountBalance.MinimumWidth = 6;
            accountBalance.Name = "accountBalance";
            // 
            // dateTimePickerAcc
            // 
            dateTimePickerAcc.Location = new Point(771, 323);
            dateTimePickerAcc.Name = "dateTimePickerAcc";
            dateTimePickerAcc.Size = new Size(622, 29);
            dateTimePickerAcc.TabIndex = 68;
            // 
            // btnCAClose
            // 
            btnCAClose.BackColor = Color.Silver;
            btnCAClose.Font = new Font("Constantia", 13.8F);
            btnCAClose.ForeColor = SystemColors.ButtonHighlight;
            btnCAClose.Location = new Point(1300, 886);
            btnCAClose.Name = "btnCAClose";
            btnCAClose.Size = new Size(93, 38);
            btnCAClose.TabIndex = 67;
            btnCAClose.Text = "Close";
            btnCAClose.UseVisualStyleBackColor = false;
            btnCAClose.Click += btnCAClose_Click;
            // 
            // btnCASave
            // 
            btnCASave.BackColor = SystemColors.GradientInactiveCaption;
            btnCASave.Font = new Font("Constantia", 13.8F);
            btnCASave.ForeColor = SystemColors.ActiveCaptionText;
            btnCASave.Location = new Point(1188, 886);
            btnCASave.Name = "btnCASave";
            btnCASave.Size = new Size(93, 38);
            btnCASave.TabIndex = 66;
            btnCASave.Text = "Save";
            btnCASave.UseVisualStyleBackColor = false;
            btnCASave.Click += btnCASave_Click;
            btnCASave.KeyDown += AccountButton_Enter;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBalance.Location = new Point(545, 394);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(107, 35);
            labelBalance.TabIndex = 63;
            labelBalance.Text = "Balance";
            // 
            // btnCADel
            // 
            btnCADel.BackColor = SystemColors.ButtonFace;
            btnCADel.Font = new Font("Constantia", 13.8F);
            btnCADel.ForeColor = SystemColors.ActiveCaptionText;
            btnCADel.Location = new Point(1080, 886);
            btnCADel.Name = "btnCADel";
            btnCADel.Size = new Size(93, 38);
            btnCADel.TabIndex = 62;
            btnCADel.Text = "Delete";
            btnCADel.UseVisualStyleBackColor = false;
            btnCADel.Click += btnCADel_Click;
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelAccount.Location = new Point(921, 79);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(281, 45);
            labelAccount.TabIndex = 61;
            labelAccount.Text = "Create Account";
            // 
            // labelDateOpened
            // 
            labelDateOpened.AutoSize = true;
            labelDateOpened.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateOpened.Location = new Point(545, 313);
            labelDateOpened.Name = "labelDateOpened";
            labelDateOpened.Size = new Size(175, 35);
            labelDateOpened.TabIndex = 58;
            labelDateOpened.Text = "Date Opened";
            // 
            // labelCusID
            // 
            labelCusID.AutoSize = true;
            labelCusID.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCusID.Location = new Point(545, 233);
            labelCusID.Name = "labelCusID";
            labelCusID.Size = new Size(169, 35);
            labelCusID.TabIndex = 57;
            labelCusID.Text = "Customer ID";
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(txtCustomerId);
            tabCustomer.Controls.Add(txtCusPin);
            tabCustomer.Controls.Add(txtCusCity);
            tabCustomer.Controls.Add(txtCusHouseNo);
            tabCustomer.Controls.Add(txtCusEmail);
            tabCustomer.Controls.Add(txtCusPhone);
            tabCustomer.Controls.Add(txtCusName);
            tabCustomer.Controls.Add(labelCustomerId);
            tabCustomer.Controls.Add(panel1);
            tabCustomer.Controls.Add(labelPin);
            tabCustomer.Controls.Add(labelCity);
            tabCustomer.Controls.Add(labelCusHouseNo);
            tabCustomer.Controls.Add(btnCCClose);
            tabCustomer.Controls.Add(btnCCSave);
            tabCustomer.Controls.Add(labelCusEmail);
            tabCustomer.Controls.Add(btnCCDelete);
            tabCustomer.Controls.Add(labelCustomer);
            tabCustomer.Controls.Add(labelCusPhone);
            tabCustomer.Controls.Add(labelCusName);
            tabCustomer.Location = new Point(4, 31);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(1912, 1045);
            tabCustomer.TabIndex = 0;
            tabCustomer.Text = "Create Customer";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = SystemColors.MenuBar;
            txtCustomerId.BorderStyle = BorderStyle.None;
            txtCustomerId.Font = new Font("Constantia", 16.2F);
            txtCustomerId.Location = new Point(463, 154);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(402, 33);
            txtCustomerId.TabIndex = 59;
            // 
            // txtCusPin
            // 
            txtCusPin.BackColor = SystemColors.MenuBar;
            txtCusPin.BorderStyle = BorderStyle.None;
            txtCusPin.Font = new Font("Constantia", 16.2F);
            txtCusPin.Location = new Point(1106, 311);
            txtCusPin.Name = "txtCusPin";
            txtCusPin.Size = new Size(420, 33);
            txtCusPin.TabIndex = 56;
            // 
            // txtCusCity
            // 
            txtCusCity.BackColor = SystemColors.MenuBar;
            txtCusCity.BorderStyle = BorderStyle.None;
            txtCusCity.Font = new Font("Constantia", 16.2F);
            txtCusCity.Location = new Point(1106, 229);
            txtCusCity.Name = "txtCusCity";
            txtCusCity.Size = new Size(420, 33);
            txtCusCity.TabIndex = 54;
            // 
            // txtCusHouseNo
            // 
            txtCusHouseNo.BackColor = SystemColors.MenuBar;
            txtCusHouseNo.BorderStyle = BorderStyle.None;
            txtCusHouseNo.Font = new Font("Constantia", 16.2F);
            txtCusHouseNo.Location = new Point(1106, 147);
            txtCusHouseNo.Name = "txtCusHouseNo";
            txtCusHouseNo.Size = new Size(420, 33);
            txtCusHouseNo.TabIndex = 52;
            // 
            // txtCusEmail
            // 
            txtCusEmail.BackColor = SystemColors.MenuBar;
            txtCusEmail.BorderStyle = BorderStyle.None;
            txtCusEmail.Font = new Font("Constantia", 16.2F);
            txtCusEmail.Location = new Point(463, 382);
            txtCusEmail.Name = "txtCusEmail";
            txtCusEmail.Size = new Size(402, 33);
            txtCusEmail.TabIndex = 44;
            // 
            // txtCusPhone
            // 
            txtCusPhone.BackColor = SystemColors.MenuBar;
            txtCusPhone.BorderStyle = BorderStyle.None;
            txtCusPhone.Font = new Font("Constantia", 16.2F);
            txtCusPhone.Location = new Point(463, 301);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(402, 33);
            txtCusPhone.TabIndex = 40;
            // 
            // txtCusName
            // 
            txtCusName.BackColor = SystemColors.MenuBar;
            txtCusName.BorderStyle = BorderStyle.None;
            txtCusName.Font = new Font("Constantia", 16.2F);
            txtCusName.Location = new Point(463, 221);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(402, 33);
            txtCusName.TabIndex = 39;
            // 
            // labelCustomerId
            // 
            labelCustomerId.AutoSize = true;
            labelCustomerId.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerId.Location = new Point(331, 154);
            labelCustomerId.Name = "labelCustomerId";
            labelCustomerId.Size = new Size(46, 35);
            labelCustomerId.TabIndex = 58;
            labelCustomerId.Text = "ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewCus);
            panel1.Location = new Point(335, 463);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 388);
            panel1.TabIndex = 57;
            // 
            // dataGridViewCus
            // 
            dataGridViewCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCus.Columns.AddRange(new DataGridViewColumn[] { customerId, customerName, customerPhone, customerEmail, customerHouseNo, customerCity, customerPin });
            dataGridViewCus.Location = new Point(3, 0);
            dataGridViewCus.Name = "dataGridViewCus";
            dataGridViewCus.RowHeadersWidth = 51;
            dataGridViewCus.Size = new Size(1206, 417);
            dataGridViewCus.TabIndex = 37;
            dataGridViewCus.CellClick += dataGridViewCus_Click;
            // 
            // customerId
            // 
            customerId.DataPropertyName = "id";
            customerId.HeaderText = "Customer ID";
            customerId.MinimumWidth = 6;
            customerId.Name = "customerId";
            customerId.ReadOnly = true;
            customerId.Width = 165;
            // 
            // customerName
            // 
            customerName.DataPropertyName = "name";
            customerName.HeaderText = "Name";
            customerName.MinimumWidth = 6;
            customerName.Name = "customerName";
            customerName.Width = 280;
            // 
            // customerPhone
            // 
            customerPhone.DataPropertyName = "phone";
            customerPhone.HeaderText = "Phone";
            customerPhone.MinimumWidth = 6;
            customerPhone.Name = "customerPhone";
            customerPhone.Width = 125;
            // 
            // customerEmail
            // 
            customerEmail.DataPropertyName = "email";
            customerEmail.HeaderText = "Email";
            customerEmail.MinimumWidth = 6;
            customerEmail.Name = "customerEmail";
            customerEmail.Width = 125;
            // 
            // customerHouseNo
            // 
            customerHouseNo.DataPropertyName = "house_no";
            customerHouseNo.HeaderText = "House No";
            customerHouseNo.MinimumWidth = 6;
            customerHouseNo.Name = "customerHouseNo";
            customerHouseNo.Width = 125;
            // 
            // customerCity
            // 
            customerCity.DataPropertyName = "city";
            customerCity.HeaderText = "City";
            customerCity.MinimumWidth = 6;
            customerCity.Name = "customerCity";
            customerCity.Width = 125;
            // 
            // customerPin
            // 
            customerPin.DataPropertyName = "pin";
            customerPin.HeaderText = "Pin";
            customerPin.MinimumWidth = 6;
            customerPin.Name = "customerPin";
            customerPin.Width = 190;
            // 
            // labelPin
            // 
            labelPin.AutoSize = true;
            labelPin.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPin.Location = new Point(943, 311);
            labelPin.Name = "labelPin";
            labelPin.Size = new Size(55, 35);
            labelPin.TabIndex = 55;
            labelPin.Text = "Pin";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCity.Location = new Point(943, 229);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(64, 35);
            labelCity.TabIndex = 53;
            labelCity.Text = "City";
            // 
            // labelCusHouseNo
            // 
            labelCusHouseNo.AutoSize = true;
            labelCusHouseNo.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCusHouseNo.Location = new Point(943, 147);
            labelCusHouseNo.Name = "labelCusHouseNo";
            labelCusHouseNo.Size = new Size(139, 35);
            labelCusHouseNo.TabIndex = 51;
            labelCusHouseNo.Text = "House No.";
            // 
            // btnCCClose
            // 
            btnCCClose.BackColor = Color.Silver;
            btnCCClose.Font = new Font("Constantia", 13.8F);
            btnCCClose.ForeColor = SystemColors.ButtonHighlight;
            btnCCClose.Location = new Point(1433, 886);
            btnCCClose.Name = "btnCCClose";
            btnCCClose.Size = new Size(93, 38);
            btnCCClose.TabIndex = 50;
            btnCCClose.Text = "Close";
            btnCCClose.UseVisualStyleBackColor = false;
            btnCCClose.Click += btnCCClose_Click;
            // 
            // btnCCSave
            // 
            btnCCSave.BackColor = SystemColors.GradientInactiveCaption;
            btnCCSave.Font = new Font("Constantia", 13.8F);
            btnCCSave.ForeColor = SystemColors.ActiveCaptionText;
            btnCCSave.Location = new Point(1321, 886);
            btnCCSave.Name = "btnCCSave";
            btnCCSave.Size = new Size(93, 38);
            btnCCSave.TabIndex = 49;
            btnCCSave.Text = "Save";
            btnCCSave.UseVisualStyleBackColor = false;
            btnCCSave.Click += btnCCSave_Click;
            btnCCSave.KeyDown += CustomerButton_Enter;
            // 
            // labelCusEmail
            // 
            labelCusEmail.AutoSize = true;
            labelCusEmail.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCusEmail.Location = new Point(331, 382);
            labelCusEmail.Name = "labelCusEmail";
            labelCusEmail.Size = new Size(84, 35);
            labelCusEmail.TabIndex = 43;
            labelCusEmail.Text = "Email";
            // 
            // btnCCDelete
            // 
            btnCCDelete.BackColor = SystemColors.ButtonFace;
            btnCCDelete.Font = new Font("Constantia", 13.8F);
            btnCCDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnCCDelete.Location = new Point(1213, 886);
            btnCCDelete.Name = "btnCCDelete";
            btnCCDelete.Size = new Size(93, 38);
            btnCCDelete.TabIndex = 42;
            btnCCDelete.Text = "Delete";
            btnCCDelete.UseVisualStyleBackColor = false;
            btnCCDelete.Click += btnCCDelete_Click;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Constantia", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelCustomer.Location = new Point(816, 42);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(309, 45);
            labelCustomer.TabIndex = 41;
            labelCustomer.Text = "Create Customer";
            // 
            // labelCusPhone
            // 
            labelCusPhone.AutoSize = true;
            labelCusPhone.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCusPhone.Location = new Point(331, 301);
            labelCusPhone.Name = "labelCusPhone";
            labelCusPhone.Size = new Size(91, 35);
            labelCusPhone.TabIndex = 38;
            labelCusPhone.Text = "Phone";
            // 
            // labelCusName
            // 
            labelCusName.AutoSize = true;
            labelCusName.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCusName.Location = new Point(331, 221);
            labelCusName.Name = "labelCusName";
            labelCusName.Size = new Size(85, 35);
            labelCusName.TabIndex = 37;
            labelCusName.Text = "Name";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabCustomer);
            tabControl.Controls.Add(tabAccount);
            tabControl.Controls.Add(tabTrans);
            tabControl.Controls.Add(tabBalance);
            tabControl.Controls.Add(tabTransLog);
            tabControl.Location = new Point(8, 13);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1920, 1080);
            tabControl.TabIndex = 0;
            tabControl.KeyDown += CancelForm;
            // 
            // Banking
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(tabControl);
            Font = new Font("Constantia", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Banking";
            StartPosition = FormStartPosition.Manual;
            Text = "Banking";
            WindowState = FormWindowState.Maximized;
            tabTransLog.ResumeLayout(false);
            tabTransLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransLog).EndInit();
            tabBalance.ResumeLayout(false);
            tabBalance.PerformLayout();
            tabTrans.ResumeLayout(false);
            tabTrans.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTrans).EndInit();
            tabAccount.ResumeLayout(false);
            tabAccount.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            tabCustomer.ResumeLayout(false);
            tabCustomer.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCus).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabTransLog;
        private DataGridView dataGridViewTransLog;
        private Label labelTransLog;
        private TabPage tabBalance;
        private TextBox txtBalanceAmount;
        private TextBox txtBalancePin;
        private TextBox txtBalanceBranchId;
        private TextBox txtBalanceAccId;
        private Label labelBalanceAmount;
        private Button btnBalanceCancel;
        private Button btnBalanceCheck;
        private Label labelBalancePin;
        private Label labelBalanceBranchId;
        private Label labelBalanceAcc;
        private Label labelBalanceAccId;
        private TabPage tabTrans;
        private Panel panel3;
        private DataGridView dataGridViewTrans;
        private Label label2;
        private RadioButton radioTrans;
        private RadioButton radioWithdraw;
        private RadioButton radioDeposit;
        private Button btnTransCancel;
        private Button btnTransSave;
        private TextBox txtTransPin;
        private TextBox txtTransEmId;
        private TextBox txtTransAmount;
        private TextBox txtTransToAccId;
        private TextBox txtTransBranchId;
        private TextBox txtFromAccId;
        private Label labelTransPin;
        private DateTimePicker dateTimePickerTrans;
        private Label labelTransEmId;
        private Label labelTransAmount;
        private Label labelTransToAccId;
        private Label labelDateOfTrans;
        private Label labelTrans;
        private Label labelTransBranchId;
        private Label labelTransFromAccId;
        private TabPage tabAccount;
        private TextBox txtAccId;
        private TextBox txtAccBalance;
        private TextBox txtCusID;
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridViewAccount;
        private DataGridViewTextBoxColumn accountId;
        private DataGridViewTextBoxColumn accCusId;
        private DataGridViewTextBoxColumn accountDateOpened;
        private DataGridViewTextBoxColumn accountBalance;
        private DateTimePicker dateTimePickerAcc;
        private Button btnCAClose;
        private Button btnCASave;
        private Label labelBalance;
        private Button btnCADel;
        private Label labelAccount;
        private Label labelDateOpened;
        private Label labelCusID;
        private TabPage tabCustomer;
        private TextBox txtCustomerId;
        private TextBox txtCusPin;
        private TextBox txtCusCity;
        private TextBox txtCusHouseNo;
        private TextBox txtCusEmail;
        private TextBox txtCusPhone;
        private TextBox txtCusName;
        private Label labelCustomerId;
        private Panel panel1;
        private DataGridView dataGridViewCus;
        private DataGridViewTextBoxColumn customerId;
        private DataGridViewTextBoxColumn customerName;
        private DataGridViewTextBoxColumn customerPhone;
        private DataGridViewTextBoxColumn customerEmail;
        private DataGridViewTextBoxColumn customerHouseNo;
        private DataGridViewTextBoxColumn customerCity;
        private DataGridViewTextBoxColumn customerPin;
        private Label labelPin;
        private Label labelCity;
        private Label labelCusHouseNo;
        private Button btnCCClose;
        private Button btnCCSave;
        private Label labelCusEmail;
        private Button btnCCDelete;
        private Label labelCustomer;
        private Label labelCusPhone;
        private Label labelCusName;
        private TabControl tabControl;
        private DataGridViewTextBoxColumn transId;
        private DataGridViewTextBoxColumn fromAccId;
        private DataGridViewTextBoxColumn toAccId;
        private DataGridViewTextBoxColumn transAmount;
        private DataGridViewTextBoxColumn transType;
        private DataGridViewTextBoxColumn transBranchId;
        private DataGridViewTextBoxColumn transDate;
        private DataGridViewTextBoxColumn transPin;
        private DataGridViewTextBoxColumn transemId;
    }
}