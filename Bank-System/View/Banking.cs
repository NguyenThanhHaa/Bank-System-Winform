using Bank_System.Controller;
using Bank_System.Model;
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
    public partial class Banking : Form,IView
    {
        private CustomerController customerController;
        private AccountController accountController;
        private TransactionController transactionController;

        private string _employeeId;

        public string SelectedTab { get; set; }

        private bool isCustomerDataLoaded = false;

        private bool isAccountDataLoaded = false;

        private bool isTransactionDataLoaded = false;


        public Banking()
        {
            InitializeComponent();

            customerController = new CustomerController();
            accountController = new AccountController();
            transactionController = new TransactionController();

            this.Load += new EventHandler(BankingForm_Load);
            this.KeyPreview = true;

            // Đăng ký sự kiện KeyDown cho Form
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            // Đăng ký sự kiện khi tab được chọn
            this.tabControl.SelectedIndexChanged += new EventHandler(TabControl_SelectedIndexChanged);

            // Đăng ký sự kiện cho các radio button
            radioDeposit.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioWithdraw.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioTrans.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        // Method mở đúng tab cần chọn
        private void BankingForm_Load(object sender, EventArgs e)
        {
            if (SelectedTab == "Create Customer")
            {
                tabControl.SelectedTab = tabCustomer;
                LoadCustomerData();
                isCustomerDataLoaded = true;
            }
            else if (SelectedTab == "Create Account")
            {
                tabControl.SelectedTab = tabAccount;
                LoadAccountData();
                isAccountDataLoaded = true;
            }
            else if (SelectedTab == "Transaction Amount")
            {
                tabControl.SelectedTab = tabTrans;
                LoadTransactionData();
                isTransactionDataLoaded = true;
            }
        }

        // Method xử lý khi tab được chọn
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tab được chọn và load dữ liệu tương ứng cho tab đó
            if (tabControl.SelectedTab == tabCustomer && !isCustomerDataLoaded)
            {
                LoadCustomerData();
                isCustomerDataLoaded = true;
            }
            else if (tabControl.SelectedTab == tabAccount && !isAccountDataLoaded)
            {
                LoadAccountData();
                isAccountDataLoaded = true;
            }
            else if (tabControl.SelectedTab == tabTrans && !isTransactionDataLoaded)
            {
                LoadTransactionData();
                isTransactionDataLoaded = true;
            }
        }

        // Load dữ liệu
        // customer từ cơ sở dữ liệu lên DataGridView
        private void LoadCustomerData()
        {
            DataTable customers = customerController.Load();
            dataGridViewCus.DataSource = customers;
        }

        // Load dữ liệu
        // account từ cơ sở dữ liệu lên DataGridView
        private void LoadAccountData()
        {
            DataTable accounts = accountController.Load();
            dataGridViewAccount.DataSource = accounts;
        }


        // Load dữ liệu
        // transaction từ cơ sở dữ liệu lên DataGridView
        private void LoadTransactionData()
        {
            DataTable transactions = transactionController.Load();
            dataGridViewTrans.DataSource = transactions;
        }

        // Handler event khi chọn một row trên
        // DataGridView Customer
        private void dataGridViewCus_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCus.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["customerId"].Value.ToString();
                txtCusName.Text = row.Cells["customerName"].Value.ToString();
                txtCusPhone.Text = row.Cells["customerPhone"].Value.ToString();
                txtCusEmail.Text = row.Cells["customerEmail"].Value.ToString();
                txtCusHouseNo.Text = row.Cells["customerHouseNo"].Value.ToString();
                txtCusCity.Text = row.Cells["customerCity"].Value.ToString();
                txtCusPin.Text = row.Cells["customerPin"].Value.ToString();
            }

        }

        // Handler event khi chọn một row trên
        // DataGridView Account
        private void datagridViewAccount_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAccount.Rows[e.RowIndex];
                //txtAccId.Text = row.Cells["accountId"].Value.ToString();
                txtCusID.Text = row.Cells["accCusId"].Value.ToString();
                dateTimePickerAcc.Text = row.Cells["accountDateOpened"].Value.ToString();
                txtAccBalance.Text = row.Cells["accountBalance"].Value.ToString();

            }
        }

        //Thêm mới customer
        private void btnCCSave_Click(object sender, EventArgs e)
        {
            if (CheckTextCustomerStatus())
            {
                var customer = new CustomerModel()
                {
                    id = txtCustomerId.Text,
                    name = txtCusName.Text,
                    phone = txtCusPhone.Text,
                    email = txtCusEmail.Text,
                    house_no = txtCusHouseNo.Text,
                    city = txtCusCity.Text,
                    pin = txtCusPin.Text
                };

                if (!customerController.IsExist(customer.id))
                {
                    DialogResult dialogResult = MessageBox.Show($"The ID is not exists! Do you want to add new?",
                                                "Warning",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thêm mới customer 
                        if (customerController.Create(customer))
                        {
                            ShowMessage("Added successfully!", "Success", MessageBoxIcon.Information);
                            LoadCustomerData();
                        }
                        else
                        {
                            ShowMessage("Failed to add the customer. Please try again.", "Error", MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"The ID was already exists! Do you want to update?",
                                               "Warning",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);


                    if (dialogResult == DialogResult.Yes)
                    {
                        updateCustomer(sender, e);
                    }
                }


            }
        }

        //Thêm mới account
        private void btnCASave_Click(object sender, EventArgs e)
        {
            if (CheckTextAccountStatus())
            {
                var account = new AccountModel()
                {
                    id = int.TryParse(txtAccId.Text, out var id) ? id : 0,
                    customerid = txtCusID.Text,
                    date_opened = DateOnly.FromDateTime(dateTimePickerAcc.Value),
                    balance = float.TryParse(txtAccBalance.Text, out var balance) ? balance : 0f,
                };

                if (!accountController.IsExist(account.id))
                {


                    DialogResult dialogResult = MessageBox.Show($"The {account.id} is already exists! Do you want to add new?",
                                                "Warning",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thêm mới account 
                        if (accountController.Create(account))
                        {
                            ShowMessage("Added successfully!", "Success", MessageBoxIcon.Information);
                            LoadAccountData();
                        }
                        else
                        {
                            ShowMessage("Failed to add the account. Please try again.", "Error", MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"The ID was already exists! Do you want to update?",
                                               "Warning",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);


                    if (dialogResult == DialogResult.Yes)
                    {
                        updateAccount(sender, e);
                    }
                }


            }
        }

        //Thêm mới trans
        private void btnTransSave_Click(object sender, EventArgs e)
        {
            if (CheckTextDepositStatus())
            {
                int fromAccountId = int.TryParse(txtFromAccId.Text, out var id) ? id : 0;
                int toAccountId = int.TryParse(txtTransToAccId.Text, out var _toid) ? _toid : 0;
                string branchId = txtTransBranchId.Text;
                string employeeId = txtTransEmId.Text;
                float amount = float.TryParse(txtTransAmount.Text, out float parsedAmount) ? parsedAmount : 0f;
                string pin = txtTransPin.Text;

                if (radioDeposit.Checked)
                {
                    txtTransToAccId.Enabled = false;
                    HandleDeposit(fromAccountId, amount, employeeId, branchId, pin);
                    LoadTransactionData();
                    LoadAccountData();
                }
                else if (radioWithdraw.Checked)
                {
                    txtTransToAccId.Enabled = false;
                    HandleWithdraw(fromAccountId, amount, employeeId, branchId, pin);
                    LoadTransactionData();
                    LoadAccountData();
                }
                else if (radioTrans.Checked)
                {
                    HandleTransfer(fromAccountId, toAccountId, amount, employeeId, branchId, pin);
                    LoadTransactionData();
                    LoadAccountData();
                }
            }
            


        }

        // Xử lý khi thay đổi lựa chọn loại giao dịch
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeposit.Checked)
            {
                
                txtTransToAccId.Enabled = false;
            }
            else if (radioWithdraw.Checked)
            {
                txtTransToAccId.Enabled = false;
            }
            //else if (radioTrans.Checked)
            //{
            //    btnTransSave.Text = "Transfer";
            //}
        }
        // Hàm xử lý Deposit
        private void HandleDeposit(int accountId, float amount, string employeeId, string branchId, string pin)
        {
            var transaction = new TransactionModel
            {
                from_account_id = accountId,
                amount = amount,
                employee_id = employeeId,
                branch_id = branchId,
                pin = pin,
                trans_type = "Deposit",
                date_of_trans = DateTime.Now
            };

            try
            {
                if (transactionController.Deposit(transaction))
                {
                    ShowMessage("Deposit successful!", "Success", MessageBoxIcon.Information);
                }
                else {
                    ShowMessage("Fail", "Fail", MessageBoxIcon.Information);
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Hàm xử lý Withdraw
        private void HandleWithdraw(int accountId, float amount, string employeeId, string branchId, string pin)
        {
            var transaction = new TransactionModel
            {
                from_account_id = accountId,
                amount = amount,
                employee_id = employeeId,
                branch_id = branchId,
                pin = pin,
                trans_type = "Withdraw",
                date_of_trans = DateTime.Now
            };

            try
            {
                if (transactionController.Withdraw(transaction))
                {
                    ShowMessage("Withdraw successful!", "Success", MessageBoxIcon.Information);
                }
                else
                {
                    ShowMessage("Fail", "Fail", MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Hàm xử lý Transfer
        private void HandleTransfer(int fromAccountId, int toAccountId, float amount, string employeeId, string branchId, string pin)
        {
            var transaction = new TransactionModel
            {
                from_account_id = fromAccountId,
                to_account_id = toAccountId,
                amount= amount,
                employee_id = employeeId,
                branch_id = branchId,
                pin = pin,
                trans_type = "Transfer",
                date_of_trans = DateTime.Now
            };

            if (transactionController.Transfer(transaction))
            {
                ShowMessage("Transfer successful!", "Success", MessageBoxIcon.Information);
            }
            else
            {
                ShowMessage("Failed to transfer. Please try again.", "Error", MessageBoxIcon.Error);
            }
        }

        // Cập nhật customer
        private void updateCustomer(object sender, EventArgs e)
        {
            var customer = new CustomerModel()
            {
                id = txtCustomerId.Text,
                name = txtCusName.Text,
                phone = txtCusPhone.Text,
                email = txtCusEmail.Text,
                house_no = txtCusHouseNo.Text,
                city = txtCusCity.Text,
                pin = txtCusPin.Text
            };

            if (customerController.Update(customer))
            {
                ShowMessage("Update successfully!", "Success", MessageBoxIcon.Information);
                LoadCustomerData();  // Reload dữ liệu
            }
            else
            {
                ShowMessage("Failed to update the employee. Please try again.", "Error", MessageBoxIcon.Error);
            }
        }

        // Cập nhật account
        private void updateAccount(object sender, EventArgs e)
        {
            var account = new AccountModel()
            {
                id = int.TryParse(txtAccId.Text, out var id) ? id : 0,
                customerid = txtCusID.Text,
                date_opened = DateOnly.FromDateTime(dateTimePickerAcc.Value),
                balance = float.TryParse(txtAccBalance.Text, out var balance) ? balance : 0f
            };

            if (accountController.Update(account))
            {
                ShowMessage("Update successfully!", "Success", MessageBoxIcon.Information);
                LoadAccountData();  // Reload dữ liệu
            }
            else
            {
                ShowMessage("Failed to update the account. Please try again.", "Error", MessageBoxIcon.Error);
            }
        }

        //Xóa customer
        private void btnCCDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete customer {customerId}?",
                                                "Delete Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Xóa customer
                if (customerController.Delete(customerId))
                {
                    ShowMessage("Customer deleted successfully!", "Success", MessageBoxIcon.Information);
                    LoadCustomerData();
                }
                else
                {
                    ShowMessage("Failed to delete the customer. Please try again.", "Error", MessageBoxIcon.Error);
                }
            }
        }

        //Xóa account 
        private void btnCADel_Click(object sender, EventArgs e)
        {
            string accountId = txtAccId.Text;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete account {accountId}?",
                                                "Delete Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Xóa account
                if (accountController.Delete(accountId))
                {
                    ShowMessage("Account deleted successfully!", "Success", MessageBoxIcon.Information);
                    LoadAccountData();
                }
                else
                {
                    ShowMessage("Failed to delete the account. Please try again.", "Error", MessageBoxIcon.Error);
                }
            }
        }

        // Hàm ShowMessage
        public void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        //Hàm kiểm tra các trường thông tin đã nhập đủ hay chưa 
        public Boolean CheckText(Dictionary<TextBox, string> fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Key.Text))
                {
                    MessageBox.Show(field.Value);
                    return false;
                }
            }
            return true;
        }

        private Boolean CheckTextCustomerStatus()
        {

            var fields = new Dictionary<TextBox, string>
            {
                { txtCustomerId, "The Customer ID is required!" },
                { txtCusName, "The Name is required!" },
                { txtCusHouseNo, "The House No is required!" },
                { txtCusCity, "The City is required!" }
            };

            return CheckText(fields);

        }

        private Boolean CheckTextAccountStatus()
        {
            var fields = new Dictionary<TextBox, string>
            {
                { txtCusID, "The Customer ID is required!" },
                { txtAccBalance, "The Balance is required!" }
            };

            return CheckText(fields);

        }

        private Boolean CheckTextDepositStatus()
        {
            var fields = new Dictionary<TextBox, string>
            {
                { txtFromAccId, "The From Account ID is required!" },
                { txtTransAmount, "The Amount is required!" },
                { txtTransBranchId, "The Branch ID is required!" },
                { txtTransPin, "The PIN is required!" },
                { txtTransEmId, "The Employee ID is required!" }
            };

            return CheckText(fields);

        }

        private void btnCCClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to close this form?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCAClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to close this form?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Xử lý sự kiện hủy form khi nhấn 'esc' 
        private void CancelForm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to close this form?",
                                               "Confirmation",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        //Xử lý sự kiện nhấn enter form Create Customer
        private void CustomerButton_Enter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnCCSave_Click(sender, e);
            }

        }

        //Xử lý sự kiện nhấn enter form Create Account
        private void AccountButton_Enter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnCASave_Click(sender, e);
            }

        }

        // Phương thức xử lý sự kiện KeyDown tổng quát
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra tab đang được chọn và gọi hàm tương ứng
                if (tabControl.SelectedTab == tabCustomer)
                {
                    btnCCSave_Click(sender, e);
                }
                else if (tabControl.SelectedTab == tabAccount)
                {
                    btnCASave_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // Kiểm tra tab đang được chọn và gọi hàm delete tương ứng
                if (tabControl.SelectedTab == tabCustomer)
                {
                    btnCCDelete_Click(sender, e);
                }
                else if (tabControl.SelectedTab == tabAccount)
                {
                    btnCADel_Click(sender, e);
                }
            }
        }

        public bool CheckTextStatus(Dictionary<TextBox, string> fields)
        {
            throw new NotImplementedException();
        }
    }
}

