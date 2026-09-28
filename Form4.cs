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
    public partial class Form4 : Form
    {
        private long ID = 0;
        private long AccountNumber = 0;
        private double AccountBalance = 0;
        private double SaverBalance = 0;

        public Form4(long UserID)
        {
            InitializeComponent();
            ID = UserID;
            foreach(Account a in new allAccounts().Accounts)
            {
                if (a.UserID == ID)
                {
                    AccountNumber = a.AccountNumber;
                    AccountBalance = double.Parse(a.CurrentAccountBalance.ToString());
                    SaverBalance = double.Parse(a.SaverBalance.ToString());
                    break;
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void buttonViewWingleAccount_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(AccountNumber, ID);
            form7.Show();
            this.Close();
        }
    }
}