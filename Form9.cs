using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Grand_Wingle_Bank
{
    public partial class Form9 : Form
    {
        private long Number = 0;
        private long ID = 0;
        public Form9(long AccountNumber, long UserID)
        {
            InitializeComponent();
            this.Number = AccountNumber;
            this.ID = UserID;
            buttonContinue.Hide();
        }
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            textBoxSuccess.Text = "Success! Your money has been transferred ";
            buttonContinue.Show();
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToInt32(textBoxAmount.Text.Substring(1, textBoxAmount.Text.Length - 1));
            decimal accountBalance = 0;
            decimal saverBalance = 0;
            long saverNumber = 0;
            long userID = 0;
            foreach (Account userAccount in new allAccounts().Accounts)
            {
                if (userAccount.AccountNumber == Number)
                {
                    userID = Convert.ToInt64(userAccount.UserID);
                    accountBalance = userAccount.CurrentAccountBalance;
                    saverBalance = Convert.ToDecimal(userAccount.SaverBalance);
                    saverNumber = Convert.ToInt64(userAccount.SaverNumber);
                }
            }
            SqlConnection connection = new SqlConnection(Database.connection);
            connection.Open();
            decimal accountBalanceAfter = accountBalance - amount;
            decimal saverBalanceAfter = saverBalance + amount;
            string AccountSql = "update [dbo].[Account] set CurrentAccountBalance = @AccountBalance SaverBalance = @SaverBalance where AccountNumber = @Number";
            using (SqlCommand command = new SqlCommand(AccountSql, connection))
            {
                command.Parameters.AddWithValue("@AccountBalance", accountBalanceAfter);
                command.Parameters.AddWithValue("@SaverBalance", saverBalanceAfter);
                command.Parameters.AddWithValue("@Number", Number);
                command.ExecuteNonQuery();
                connection.Close();
            }
            string SaverSql = "update [dbo].[Saver] set TotalBalance = @SaverBalance where UserID = @UserID";
            using (SqlCommand command = new SqlCommand(SaverSql, connection))
            {
                command.Parameters.AddWithValue("@SaverBalance", saverBalance);
                command.Parameters.AddWithValue("@UserID", userID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            string TransactionSql = "insert into [dbo].[Transaction] (AccountNumber, ReceivingNumber, Amount, DateOfTransaction, BalanceBefore, BalanceAfter, ReceivingBalanceBefore, ReceivingBalanceAfter) values (@Number, @ReceivingNumber, @Amount, @Date, @BalanceBefore, @BalanceAfter, @ReceivingBalanceBefore, @ReceivingBalanceAfter)";
            using (SqlCommand command = new SqlCommand(TransactionSql, connection))
            {
                command.Parameters.AddWithValue("@Number", Number);
                command.Parameters.AddWithValue("@ReceivingNumber", saverBalance);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@Date", DateTime.Now);
                command.Parameters.AddWithValue("@BalanceBefore", accountBalance);
                command.Parameters.AddWithValue("@BalanceAfter", accountBalanceAfter);
                command.Parameters.AddWithValue("@ReceivingBalanceBefore", saverBalance);
                command.Parameters.AddWithValue("@ReceivingBalanceAfter", saverBalanceAfter);
                command.ExecuteNonQuery();
                connection.Close();
            }
            Form4 form4 = new Form4(userID);
            form4.Show();
            this.Close();
        }
    }
}
