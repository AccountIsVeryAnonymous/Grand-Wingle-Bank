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
            double amount = Convert.ToInt32(textBoxAmount.Text.Substring(1, textBoxAmount.Text.Length - 1));
            SqlConnection connection = new SqlConnection(Database.connection);
            connection.Open();
            string updateSql = "update [dbo].[Account] [dbo].[Transaction] [dbo].[Saver] set ";
            using (SqlCommand command = new SqlCommand(updateSql, connection))
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
