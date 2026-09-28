using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_Wingle_Bank
{
    public partial class Form7 : Form
    {
        private long Number = 0;
        private long ID = 0;
        public Form7(long AccountNumber, long UserID)
        {
            InitializeComponent();
            Number = AccountNumber;
            ID = UserID;
            dataGridViewTransactions.Columns.Add("Date", "Date of transaction");
            dataGridViewTransactions.Columns.Add("Amount", "Amount transferred");
            dataGridViewTransactions.Columns.Add("Account Number", "From");
            dataGridViewTransactions.Columns.Add("Receiving Account Number", "To");
            dataGridViewTransactions.Columns.Add("Balance before", "Before");
            dataGridViewTransactions.Columns.Add("Balance after", "After");
            int count = 0;
            foreach (Transaction t in new allTransactions().Transactions)
            {
                if (t.AccountNumber == Number || t.ReceivingNumber == Number)
                {
                    if (t.AccountNumber == Number)
                    {
                        dataGridViewTransactions.Rows.Add(t.DateOfTransaction, t.Amount, t.AccountNumber, t.ReceivingNumber, t.BalanceBefore, t.BalanceAfter);

                    }
                    if (t.ReceivingNumber == Number)
                    {
                        dataGridViewTransactions.Rows.Add(t.DateOfTransaction, t.Amount, t.AccountNumber, t.ReceivingNumber, t.ReceivingBalanceBefore, t.ReceivingBalanceAfter);
                    }
                }
                count++;
                if (count >= 10)
                {
                    break;
                }
            }
        }
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }

        private void buttonTransactionStart_Click(object sender, EventArgs e)
        {

        }
    }
}
