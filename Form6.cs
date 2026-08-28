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
using Microsoft.Data.SqlClient;

namespace Grand_Wingle_Bank
{
    public partial class Form6 : Form
    {
        private DateTime DOB;
        private DateTime Date;
        private byte[] hash;
        private string ImportantName;
        private string Place;
        private string UserID;
        private string Passcode;
        private string UserForename;
        private string UserSurname;
        private Random RNG = new Random();
        public Form6(string UserForename, string UserSurname, DateTime DateOfBirth, DateTime ImportantDate, string ImportantName, string ImportantPlace)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Harve\OneDrive\Pictures\Screenshots 1\GrandWingleBankLogo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DOB = DateOfBirth;
            Date = ImportantDate;
            this.ImportantName = ImportantName;
            Place = ImportantPlace;
            this.UserForename = UserForename;
            this.UserSurname = UserSurname;
            for (int i = 1; i <= 10; i++)
            {
                UserID += Convert.ToString(RNG.Next(1, 10));
            }
            textBoxUserID.Text = UserID;
            for (int i = 1; i <= 6; i++)
            {
                Passcode = Convert.ToString(RNG.Next(1, 10));
            }
            textBoxPasscode.Text = Passcode;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passcodeBytes = Encoding.UTF8.GetBytes(Passcode);
                hash = sha256.ComputeHash(passcodeBytes);
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(Database.connection);
            string insertSql = "insert into [dbo].[User] (UserID, DOB, Hash, Date, Place, Name, UserForename, UserSurname) values (@UserID, @DOB, @Hash, @Date, @Place, @Name, @UserForename, @UserSurname)";
            using (SqlCommand command = new SqlCommand(insertSql, connection))
            {
                command.Parameters.AddWithValue("@UserID", int.Parse(UserID));
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Parameters.AddWithValue("@Hash", hash);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@Place", Place);
                command.Parameters.AddWithValue("@Name", ImportantName);
                command.Parameters.AddWithValue("@UserForename", UserForename);
                command.Parameters.AddWithValue("@UserSurname", UserSurname);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            string AccountNumber = "";
            string SortCode = "";
            for (int i = 0; i < 12; i++)
            {
                AccountNumber = Convert.ToString(RNG.Next(1, 10));
            }
            for (int i = 0; i < 6; i++)
            {
                SortCode = Convert.ToString(RNG.Next(1, 10));
            }
            string accountSql = "insert into [dbo].[Account] (UserID, 0, 0, 0, 0, AccountNumber, SortCode) values (@UserID, @TotalBalance, @CurrentAccountBalance, @SaverBalance, @SaverNumber, @AccountNumber, @SortCode)";
            using (SqlCommand command = new SqlCommand(accountSql, connection))
            {
                command.Parameters.AddWithValue("@UserID", int.Parse(UserID));
                command.Parameters.AddWithValue("@TotalBalance", 0);
                command.Parameters.AddWithValue("@CurrentAccountBalance", 0);
                command.Parameters.AddWithValue("@SaverBalance", 0);
                command.Parameters.AddWithValue("@SaverNumber", 0);
                command.Parameters.AddWithValue("@AccountNumber", int.Parse(AccountNumber));
                command.Parameters.AddWithValue("@SortCode", int.Parse(SortCode));
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            Form4 form4 = new Form4(int.Parse(UserID));
            form4.Show();
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); 
            this.Close();
        }
    }
}
