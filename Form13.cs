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
    public partial class Form13 : Form
    {
        private long Number = 0;
        private long UserID;
        public Form13(long ID, long SaverNumber)
        {
            InitializeComponent();
            UserID = ID;
            Number = SaverNumber;
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
            Form4 form4 = new Form4(UserID);
            form4.Show();
            this.Close();
        }
    }
}
