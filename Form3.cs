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
    public partial class Form3 : Form
    {
        Random RNG = new Random();
        List<User> users = new allUsers().Users;
        string answer = "";
        string question = "";
        string ID = "";

        public Form3(int userID)
        {
            InitializeComponent();
            ID = Convert.ToString(userID);
            textBoxErrorMessage.Text = "Incorrect passcode. You will now be asked a security question.";
            foreach (User user in users)
            {
                if (user.UserID == userID)
                {
                    int questionChoice = RNG.Next(1, 4);
                    MessageBox.Show(questionChoice.ToString());
                    if (questionChoice == 1)
                    {
                        answer = Convert.ToString(user.Date);
                        question = " date";
                        break;
                    }
                    else if (questionChoice == 2)
                    {
                        answer = user.Place;
                        question = " place";
                        break;
                    }
                    else if (questionChoice == 3)
                    {
                        answer = user.Name;
                        question = " name";
                        break;
                    }
                }

            }
            textBoxQuestion.Text = "Please enter your important" + question;
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            foreach (User user in users)
            {
                if (user.UserID == Convert.ToInt32(ID) && textBoxAnswer.Text == answer)
                {
                    Form4 form4 = new Form4(user.UserID);
                    form4.Show();
                    this.Hide();
                    return;
                }
            }
            textBoxErrorMessage.Text = "Account locked. Please contact customer services";
            SqlConnection connection = new SqlConnection(Database.connection);
            connection.Open();
            MessageBox.Show(connection.Database);
            string updateSql = "update [dbo].[User] set LockedTime = @LockedTime where UserID = @UserID";
            using (SqlCommand command = new SqlCommand(updateSql, connection))
            {
                command.Parameters.AddWithValue("@LockedTime", DateTime.Now);
                command.Parameters.AddWithValue("@UserID", ID);
                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(rowsAffected.ToString());
            }
        }
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Close();
        }
    }
}
