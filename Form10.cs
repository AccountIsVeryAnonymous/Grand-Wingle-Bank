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
    public partial class Form10 : Form
    {
        long Number = 0;
        long ID = 0;
        public Form10(long AccountNumber, long UserID)
        {
            this.Number = AccountNumber;
            this.ID = UserID;
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            string FirstName = textBoxFirstName.Text;
            string LastName = textBoxLastName.Text;
            int SortCode = Convert.ToInt32(textBoxSortCode.Text);
            long AccountNumber = Convert.ToInt64(textBoxAccountNumber.Text);
            decimal amount = decimal.Parse(textBoxAmount.Text);
            foreach (Account receivingAccount in new allAccounts().Accounts)
            {
                foreach (User receivingUser in new allUsers().Users)
                {
                    if (receivingAccount.AccountNumber == AccountNumber && receivingAccount.SortCode == SortCode)
                    {
                        if (receivingUser.UserForename == FirstName && receivingUser.UserSurname == LastName)
                        {
                            Form11 form11 = new Form11(this.ID, this.Number, FirstName, LastName, SortCode, AccountNumber, amount);
                            form11.Show();
                            this.Close();
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Account not found. Cancelling transaction.");
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
    }
}
