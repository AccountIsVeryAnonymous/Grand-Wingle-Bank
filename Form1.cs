using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grand_Wingle_Bank
{
    public partial class Form1 : Form
    {
        private int UserID;
        private byte[] hash;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Harve\OneDrive\Pictures\Screenshots 1\GrandWingleBankLogo.png");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            allTransactions transactions = new allTransactions();
            allAccounts accounts = new allAccounts();
            allSavers savers = new allSavers();
            allUsers users = new allUsers();
        }
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userIDString = textBoxUserID.Text;
            while (true)
            {
                try
                {
                    UserID = int.Parse(userIDString);
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
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputByte = Encoding.UTF8.GetBytes(textBoxPasscode.Text);
                hash = sha256.ComputeHash(inputByte);
            }
            foreach (User u in new allUsers().Users)
            {
                if (u.UserID == UserID)
                {
                    if (u.Hash == hash)
                    {
                        Form4 form4 = new Form4(UserID);
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form3 form3 = new Form3(UserID);
                        form3.Show();
                        this.Hide();
                    }
                    break;
                }
                else
                {
                    labelError.Text = "Account not found";
                }
            }
        }
    }
}
