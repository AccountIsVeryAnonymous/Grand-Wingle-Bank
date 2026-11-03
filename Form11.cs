using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_Wingle_Bank
{
    public partial class Form11 : Form
    {
        long AccountNumber;
        long ReceivingNumber;
        int SortCode;
        string ReceivingFirstName;
        string ReceivingLastName;
        decimal amount;
        long ID;
        public Form11(long ID, long AccountNumber, string ReceivingFirstName, string ReceivingLastName, int sortCode, long ReceivingNumber, decimal amount)
        {
            this.AccountNumber = AccountNumber;
            this.ReceivingNumber = ReceivingNumber;
            this.SortCode = sortCode;
            this.ReceivingFirstName = ReceivingFirstName;
            this.ReceivingLastName = ReceivingLastName;
            this.amount = amount;
            this.ID = ID;
            InitializeComponent();
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            string FirstName = "";
            string LastName = "";
            allUsers users = new allUsers();
            foreach (User user in users.Users)
            {
                if (user.UserID == ID)
                {
                    FirstName = user.UserForename;
                    LastName = user.UserSurname;
                }
            }
            dataGridViewTransaction.Columns.Add("Account type", " ");
            dataGridViewTransaction.Columns.Add("Account number", "Account");
            dataGridViewTransaction.Columns.Add("First name", "Forename");
            dataGridViewTransaction.Columns.Add("Last name", "Surname");
            dataGridViewTransaction.Columns.Add("Amount", "Amount");
            dataGridViewTransaction.Rows.Add("From", AccountNumber, FirstName, LastName, " ");
            dataGridViewTransaction.Rows.Add("To", ReceivingNumber, ReceivingFirstName, ReceivingLastName, amount);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            decimal TotalBalance = 0;
            decimal ReceivingTotalBalance = 0;
            decimal BalanceBefore = 0;
            decimal BalanceAfter = 0;
            decimal ReceivingBalanceBefore = 0;
            decimal ReceivingBalanceAfter = 0;
            allAccounts accounts = new allAccounts();
            foreach (Account account in accounts.Accounts)
            {
                if (account.UserID == ID)
                {
                    TotalBalance = account.TotalBalance;
                    BalanceBefore = account.CurrentAccountBalance;
                    BalanceAfter = BalanceBefore - amount;
                }
                else if (account.AccountNumber == ReceivingNumber)
                {
                    ReceivingTotalBalance = account.TotalBalance;
                    ReceivingBalanceBefore = account.CurrentAccountBalance;
                    ReceivingBalanceAfter = ReceivingBalanceBefore + amount;
                }
            }
            if (BalanceAfter > 0)
            {
                SqlConnection connection = new SqlConnection(Database.connection);
                string TransactionSql = "insert into [dbo].[Transaction] (AccountNumber, ReceivingNumber, Amount, DateOfTransaction, BalanceBefore, BalanceAfter, ReceivingBalanceBefore, ReceivingBalanceAfter) values (@AccountNumber, @ReceivingNumber, @Amount, @Date, @BalanceBefore, @BalanceAfter, @ReceivingBalanceBefore, @ReceivingBalanceAfter)";
                using (SqlCommand command = new SqlCommand(TransactionSql, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@ReceivingNumber", ReceivingNumber);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@BalanceBefore", BalanceBefore);
                    command.Parameters.AddWithValue("@BalanceAfter", BalanceAfter);
                    command.Parameters.AddWithValue("@ReceivingBalanceBefore", ReceivingBalanceBefore);
                    command.Parameters.AddWithValue("@ReceivingBalanceAfter", ReceivingBalanceAfter);
                }
                string AccountSql = "update [dbo].[Account] set TotalBalance = @TotalBalance, CurrentAccountBalance = @CurrentAccountBalance where UserID = @ID";
                using (SqlCommand command = new SqlCommand(AccountSql, connection))
                {
                    command.Parameters.AddWithValue("@TotalBalance", TotalBalance - amount);
                    command.Parameters.AddWithValue("@CurrentAccountBalance", BalanceAfter);
                }
                string ReceivingSql = "update [dbo].[Account] set TotalBalance = @ReceivingBalance, CurrentAccountBalance = @CurrentAccountBalance where AccountNumber = @ReceivingNumber";
                using (SqlCommand command = new SqlCommand(ReceivingSql, connection))
                {
                    command.Parameters.AddWithValue("@ReceivingBalance", ReceivingTotalBalance - amount);
                    command.Parameters.AddWithValue("@CurrentAccountBalance", ReceivingBalanceAfter);
                    command.Parameters.AddWithValue("@ReceivingNumber", ReceivingNumber);
                }
            }
            else
            {
                MessageBox.Show("Not enough funds. Cancelling transaction");
            }
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
    }
}