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
    public partial class Form1 : Form
    {
        private int userID;
        private byte[] hash;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allTransactions transactions = new allTransactions();
            allAccounts accounts = new allAccounts();
            allSavers savers = new allSavers();
            allUsers users = new allUsers();
        }
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userIDString = textBoxUserID.Text;
            while (true)
            {
                try
                {
                    userID = int.Parse(userIDString);
                    if (userIDString.Length == 0 || textBoxPasscode.Text.Length == 0)
                    {
                        labelError.Text = "Enter a valid user ID and passcode";
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    textBoxUserID.Clear();
                    textBoxPasscode.Clear();
                    labelError.Text = "Enter a valid user ID and passcode";
                }
            }
        }
    }
}
