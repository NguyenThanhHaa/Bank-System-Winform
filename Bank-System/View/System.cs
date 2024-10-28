using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using Bank_System.Controller;
using Bank_System.Model;

namespace Bank_System.View
{
    public partial class System : Form
    {
        private EmployeeController employeeController;

        private BranchController branchController;
        public string SelectedTab { get; set; }

        private bool isEmployeeDataLoaded = false;
        private bool isBranchDataLoaded = false;

        public System()
        {
            InitializeComponent();

            employeeController = new EmployeeController();
            branchController = new BranchController();

            this.Load += new EventHandler(SystemForm_Load);
            this.KeyPreview = true;

            // Đăng ký sự kiện KeyDown cho Form
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            // Đăng ký sự kiện khi tab được chọn
            this.tabControl.SelectedIndexChanged += new EventHandler(TabControl_SelectedIndexChanged);
        }

        // Method mở đúng tab cần chọn
        private void SystemForm_Load(object sender, EventArgs e)
        {
            if (SelectedTab == "Employee")
            {
                tabControl.SelectedTab = tabEmployee;
                LoadEmployeeData(); // Load data cho tab Employee
                isEmployeeDataLoaded = true;
            }
            else if (SelectedTab == "Branch")
            {
                tabControl.SelectedTab = tabBranch;
                LoadBranchData(); // Load data cho tab Branch
                isBranchDataLoaded = true;
            }
        }

        // Method xử lý khi tab được chọn
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tab được chọn và load dữ liệu tương ứng cho tab đó
            if (tabControl.SelectedTab == tabEmployee && !isEmployeeDataLoaded)
            {
                LoadEmployeeData();
                isEmployeeDataLoaded = true;
            }
            else if (tabControl.SelectedTab == tabBranch && !isBranchDataLoaded)
            {
                LoadBranchData();
                isBranchDataLoaded = true;
            }
        }

        // Load dữ liệu
        // nhân viên từ cơ sở dữ liệu lên DataGridView
        private void LoadEmployeeData()
        {
            DataTable employees = employeeController.Load();
            dataGridViewEm.DataSource = employees;
        }

        // Load dữ liệu
        // branch từ cơ sở dữ liệu lên DataGridView
        private void LoadBranchData()
        {
            DataTable branchs = branchController.Load();
            dataGridViewBranch.DataSource = branchs;
        }

        // Handler event khi chọn một row trên
        // DataGridView Employee
        private void dataGridViewEm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEm.Rows[e.RowIndex];
                txtEmployeeId.Text = row.Cells["EmployeeId"].Value.ToString();
                txtEmployeeName.Text = row.Cells["Name"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                if (row.Cells["Role"].Value.ToString() == "Admin")
                {
                    radioButtonAdmin.Checked = true;
                }
                else
                {
                    radioButtonUser.Checked = true;
                }
            }


        }

        // Handler event khi chọn một row trên
        // DataGridView Branch
        private void dataGridViewBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBranch.Rows[e.RowIndex];
                txtBranchId.Text = row.Cells["branchId"].Value.ToString();
                txtBranchName.Text = row.Cells["branchName"].Value.ToString();
                txtHouseNo.Text = row.Cells["branchHouseNo"].Value.ToString();
                txtCity.Text = row.Cells["branchCity"].Value.ToString();
            }
        }

        // Thêm mới employee
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextEmplStatus())
            {
                var employee = new EmployeeModel()
                {
                    id = txtEmployeeId.Text,
                    name = txtEmployeeName.Text,
                    password = txtPassword.Text,
                    role = radioButtonAdmin.Checked ? "Admin" : "User"
                };


                if (!employeeController.IsExist(employee.id))
                {
                    DialogResult dialogResult = MessageBox.Show($"The ID is not exists! Do you want to add new?",
                                                "Warning",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thêm mới nhân viên
                        if (employeeController.Create(employee))
                        {
                            ShowMessage("Added successfully!", "Success", MessageBoxIcon.Information);
                            LoadEmployeeData();
                        }
                        else
                        {
                            ShowMessage("Failed to add the employee. Please try again.", "Error", MessageBoxIcon.Error);
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
                        updateEmployee(sender, e);
                    }
                }


            }


        }
        // Thêm mới branch
        private void btnSaveBranch_Click(object sender, EventArgs e)
        {
            if (CheckTextBranchStatus())
            {
                var branch = new BranchModel()
                {
                    id = txtBranchId.Text,
                    name = txtBranchName.Text,
                    house_no = txtHouseNo.Text,
                    city = txtCity.Text
                };

                if (!branchController.IsExist(branch.id))
                {
                    DialogResult dialogResult = MessageBox.Show($"The ID is not exists! Do you want to add new?",
                                                "Warning",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Thêm mới branch 
                        if (branchController.Create(branch))
                        {
                            ShowMessage("Added successfully!", "Success", MessageBoxIcon.Information);
                            LoadBranchData();
                        }
                        else
                        {
                            ShowMessage("Failed to add the branch. Please try again.", "Error", MessageBoxIcon.Error);
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
                        updateBranch(sender, e);
                    }
                }


            }
        }
        // Cập nhật nhân viên
        private void updateEmployee(object sender, EventArgs e)
        {
            var employee = new EmployeeModel()
            {
                id = txtEmployeeId.Text,
                name = txtEmployeeName.Text,
                password = txtPassword.Text,
                role = radioButtonAdmin.Checked ? "Admin" : "User"
            };

            if (employeeController.Update(employee))
            {
                ShowMessage("Update successfully!", "Success", MessageBoxIcon.Information);
                LoadEmployeeData();
            }
            else
            {
                ShowMessage("Failed to update the employee. Please try again.", "Error", MessageBoxIcon.Error);
            }
        }

        // Cập nhật branch
        private void updateBranch(object sender, EventArgs e)
        {
            var branch = new BranchModel()
            {
                id = txtBranchId.Text,
                name = txtBranchName.Text,
                house_no = txtHouseNo.Text,
                city = txtCity.Text
            };

            if (branchController.Update(branch))
            {
                ShowMessage("Update successfully!", "Success", MessageBoxIcon.Information);
                LoadBranchData();
            }
            else
            {
                ShowMessage("Failed to update the branch. Please try again.", "Error", MessageBoxIcon.Error);
            }
        }

        // Xóa nhân viên
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeId = txtEmployeeId.Text;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete employee {employeeId}?",
                                                "Delete Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Xóa employee
                if (employeeController.Delete(employeeId))
                {
                    ShowMessage("Employee deleted successfully!", "Success", MessageBoxIcon.Information);
                    LoadEmployeeData();
                }
                else
                {
                    ShowMessage("Failed to delete the employee. Please try again.", "Error", MessageBoxIcon.Error);
                }
            }


        }

        // Xóa branch
        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            string branchId = txtBranchId.Text;

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete branch {branchId}?",
                                                "Delete Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Xóa branch
                if (branchController.Delete(branchId))
                {
                    ShowMessage("Branch deleted successfully!", "Success", MessageBoxIcon.Information);
                    LoadBranchData();
                }
                else
                {
                    ShowMessage("Failed to delete the Branch. Please try again.", "Error", MessageBoxIcon.Error);
                }
            }

        }

        // Hàm ShowMessage
        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        //Kiểm tra xem các trường thông tin đã được điền đầy đủ hay chưa 
        private Boolean CheckTextEmplStatus()
        {

            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                MessageBox.Show("The Employee ID is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("The Employee Name is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("The Password is required!");
                return false;
            }

            if (!radioButtonAdmin.Checked && !radioButtonUser.Checked)
            {
                MessageBox.Show("The Role is required!");
                return false;
            }
            return true;

        }

        private Boolean CheckTextBranchStatus()
        {

            if (string.IsNullOrWhiteSpace(txtBranchId.Text))
            {
                MessageBox.Show("The Branch ID is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBranchName.Text))
            {
                MessageBox.Show("The Branch Name is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHouseNo.Text))
            {
                MessageBox.Show("The House No is required!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("The City is required!");
                return false;
            }

            return true;

        }


        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnCloseBranch_Click(object sender, EventArgs e)
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
        

        //Xử lý sự kiện nhấn enter form Employee
        private void LoginButton_Enter(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }

        }

        //Xử lý sự kiến nhấn enter form Branch
        private void btnBranchEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveBranch_Click(sender, e);
            }
        }

        // Phương thức xử lý sự kiện KeyDown tổng quát
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra tab đang được chọn và gọi hàm tương ứng
                if (tabControl.SelectedTab == tabEmployee)
                {
                    btnSave_Click(sender, e);
                }
                else if (tabControl.SelectedTab == tabBranch)
                {
                    btnSaveBranch_Click(sender, e);
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                // Kiểm tra tab đang được chọn và gọi hàm delete tương ứng
                if (tabControl.SelectedTab == tabEmployee)
                {
                    btnDelete_Click(sender, e);
                }
                else if (tabControl.SelectedTab == tabBranch)
                {
                    btnDeleteBranch_Click(sender, e);
                }
            }
        }


        
    }
}
