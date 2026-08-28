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
        int ID = 0;
        public Form7(int UserID)
        {
            InitializeComponent();
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Harve\OneDrive\Pictures\Screenshots 1\GrandWingleBankLogo.png");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ID = UserID;
            dataGridViewTransactions.Columns.Add("Date", "Date of transaction");
            dataGridViewTransactions.Columns.Add("Amount", "Amount transferred");
            dataGridViewTransactions.Columns.Add("Account Number", "From");
            dataGridViewTransactions.Columns.Add("Receiving Account Number", "To");
            dataGridViewTransactions.Columns.Add("Balance before", "Before");
            dataGridViewTransactions.Columns.Add("Balance after", "After");
            foreach (Transaction t in new allTransactions().Transactions)
            {

            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
    }
}
