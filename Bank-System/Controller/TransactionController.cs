using Bank_System.Model;
using Bank_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bank_System.Controller
{
    internal class TransactionController : IController
    {
        private List<IModel> items;
        private DatabaseHelper DatabaseHelper;

        public TransactionController()
        {
            this.items = new List<IModel>();
            this.DatabaseHelper = new DatabaseHelper();
        }

        public List<IModel> Items
        {
            get
            {
                return this.items;
            }
        }

        // Thêm mới giao dịch
        public bool Create(IModel model)
        {
            var transactionModel = model as TransactionModel;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO TRANSACTION_SYSTEM (from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employee_id, trans_type) " +
                               "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin, @to_account_id, @employee_id, @trans_type)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                cmd.Parameters.AddWithValue("@branch_id", transactionModel.branch_id);
                cmd.Parameters.AddWithValue("@date_of_trans", transactionModel.date_of_trans);
                cmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                cmd.Parameters.AddWithValue("@pin", transactionModel.pin);
                cmd.Parameters.AddWithValue("@to_account_id", transactionModel.to_account_id);
                cmd.Parameters.AddWithValue("@employee_id", transactionModel.employee_id);
                cmd.Parameters.AddWithValue("@trans_type", transactionModel.trans_type);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Xóa giao dịch
        public bool Delete(object id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM TRANSACTION_SYSTEM WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Kiểm tra xem giao dịch có tồn tại không
        public bool IsExist(string id)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM TRANSACTION_SYSTEM WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Tải tất cả giao dịch từ cơ sở dữ liệu
        public DataTable Load()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM TRANSACTION_SYSTEM";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        // Phương thức Nạp tiền
        public bool Deposit(IModel model)
        {
            var transactionModel = model as TransactionModel;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                // Kiểm tra tài khoản tồn tại và mã PIN hợp lệ
                if (!ValidateAccountAndPin(transactionModel.from_account_id, transactionModel.pin)) return false;

                string updateBalanceQuery = "UPDATE ACCOUNT SET balance = balance + @amount WHERE id = @from_account_id";
                string insertTransactionQuery = "INSERT INTO TRANSACTION_SYSTEM (from_account_id, branch_id, date_of_trans, amount, pin, employee_id, trans_type) " +
                                                "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin, @employee_id, 'DEPOSIT')";

                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Cập nhật số dư tài khoản
                        SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, conn, transaction);
                        updateBalanceCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        updateBalanceCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        updateBalanceCmd.ExecuteNonQuery();

                        // Insert giao dịch
                        SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction);
                        insertTransactionCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        insertTransactionCmd.Parameters.AddWithValue("@branch_id", transactionModel.branch_id);
                        insertTransactionCmd.Parameters.AddWithValue("@date_of_trans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        insertTransactionCmd.Parameters.AddWithValue("@pin", transactionModel.pin);
                        insertTransactionCmd.Parameters.AddWithValue("@employee_id", transactionModel.employee_id);
                     
                        insertTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // Phương thức Rút tiền
        public bool Withdraw(IModel model)
        {
            var transactionModel = model as TransactionModel;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                // Kiểm tra tài khoản tồn tại, mã PIN hợp lệ, và đủ số dư
                if (!ValidateAccountAndPin(transactionModel.from_account_id, transactionModel.pin) || !HasSufficientBalance(transactionModel.from_account_id, transactionModel.amount)) return false;

                string updateBalanceQuery = "UPDATE ACCOUNT SET balance = balance - @amount WHERE id = @from_account_id";
                string insertTransactionQuery = "INSERT INTO TRANSACTION_SYSTEM (from_account_id, branch_id, date_of_trans, amount, pin, employee_id, trans_type) " +
                                                "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin, @employee_id, 'WITHDRAW')";

                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand updateBalanceCmd = new SqlCommand(updateBalanceQuery, conn, transaction);
                        updateBalanceCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        updateBalanceCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        updateBalanceCmd.ExecuteNonQuery();

                        SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction);
                        insertTransactionCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        insertTransactionCmd.Parameters.AddWithValue("@branch_id", transactionModel.branch_id);
                        insertTransactionCmd.Parameters.AddWithValue("@date_of_trans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        insertTransactionCmd.Parameters.AddWithValue("@pin", transactionModel.pin);
                        insertTransactionCmd.Parameters.AddWithValue("@employee_id", transactionModel.employee_id);
                        insertTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // Phương thức Chuyển tiền
        public bool Transfer(IModel model)
        {
            var transactionModel = model as TransactionModel;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                if (!ValidateAccountAndPin(transactionModel.from_account_id, transactionModel.pin) || !HasSufficientBalance(transactionModel.from_account_id, transactionModel.amount)) return false;

                string updateFromAccountQuery = "UPDATE ACCOUNT SET balance = balance - @amount WHERE id = @from_account_id";
                string updateToAccountQuery = "UPDATE ACCOUNT SET balance = balance + @amount WHERE id = @to_account_id";
                string insertTransactionQuery = "INSERT INTO TRANSACTION_SYSTEM (from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, employee_id, trans_type) " +
                                                "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin,@to_account_id, @employee_id, 'TRANSFER')";

                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand updateFromAccountCmd = new SqlCommand(updateFromAccountQuery, conn, transaction);
                        updateFromAccountCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        updateFromAccountCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        updateFromAccountCmd.ExecuteNonQuery();

                        SqlCommand updateToAccountCmd = new SqlCommand(updateToAccountQuery, conn, transaction);
                        updateToAccountCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        updateToAccountCmd.Parameters.AddWithValue("@to_account_id", transactionModel.to_account_id);
                        updateToAccountCmd.ExecuteNonQuery();

                        SqlCommand insertTransactionCmd = new SqlCommand(insertTransactionQuery, conn, transaction);
                        insertTransactionCmd.Parameters.AddWithValue("@from_account_id", transactionModel.from_account_id);
                        insertTransactionCmd.Parameters.AddWithValue("@branch_id", transactionModel.branch_id);
                        insertTransactionCmd.Parameters.AddWithValue("@date_of_trans", DateTime.Now);
                        insertTransactionCmd.Parameters.AddWithValue("@amount", transactionModel.amount);
                        insertTransactionCmd.Parameters.AddWithValue("@pin", transactionModel.pin);
                        insertTransactionCmd.Parameters.AddWithValue("@to_account_id", transactionModel.to_account_id);
                        insertTransactionCmd.Parameters.AddWithValue("@employee_id", transactionModel.employee_id);
                        insertTransactionCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        // Hàm kiểm tra số dư
        private bool HasSufficientBalance(int id, float amount)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT balance FROM ACCOUNT WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                double balance = (double)cmd.ExecuteScalar();
                return balance >= amount;
            }
        }

        // Hàm xác minh tài khoản và mã PIN
        private bool ValidateAccountAndPin(int id, string pin)
        {
            
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM ACCOUNT WHERE id = @id AND pin = @pin";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@pin", pin);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }



        public bool Update(IModel model)
        {
            
            throw new NotImplementedException();
        }
        }
    }

