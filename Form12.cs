using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Grand_Wingle_Bank
{
    public partial class Form12 : Form
    {
        private long ID;
        private byte[] hash;
        public Form12(long ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userIDString = textBoxUserID.Text;
            ID = Convert.ToInt64(userIDString);
            if (userIDString.Length == 0 || textBoxPasscode.Text.Length == 0)
            {
                MessageBox.Show("Enter a valid user ID and passcode");
                textBoxUserID.Clear();
                textBoxPasscode.Clear();
                return;
            }
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputByte = Encoding.UTF8.GetBytes(textBoxPasscode.Text);
                hash = sha256.ComputeHash(inputByte);
            }
            foreach (User u in new allUsers().Users)
            {
                if (u.UserID == ID)
                {
                    if (u.Hash.SequenceEqual(hash))
                    {
                        MessageBox.Show("WingleSaver created");
                        SqlConnection connection = new SqlConnection(Database.connection);
                        connection.Open();
                        string saverSql = "insert into [dbo].[Saver] (UserID, TotalBalance, DateOpened) values (@UserID, @TotalBalance, @DateOpened)";
                        using (SqlCommand command = new SqlCommand(saverSql, connection))
                        {
                            command.Parameters.AddWithValue("@UserID", ID);
                            command.Parameters.AddWithValue("@TotalBalance", 0);
                            command.Parameters.AddWithValue("@DateOpened", DateTime.Now);
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        Form4 form4 = new Form4(ID);
                        form4.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid user ID and passcode");
                        textBoxUserID.Clear();
                        textBoxPasscode.Clear();
                        return;
                    }
                }
            }
        }
    }
}