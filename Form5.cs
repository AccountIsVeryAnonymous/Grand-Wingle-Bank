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
    public partial class Form5 : Form
    {
        private string UserFname;
        private string UserSname;
        private DateTime DOB;
        private DateTime ImportantDate;
        private string ImportantName;
        private string ImportantPlace;
        private allUsers _users;
        public Form5(string Forename, string Surname, DateTime DateOfBirth)
        {
            InitializeComponent();
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Harve\OneDrive\Pictures\Screenshots 1\GrandWingleBankLogo.png");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.UserFname = Forename;
            this.UserSname = Surname;
            this.DOB = DateOfBirth;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDate.Text))
            {
                MessageBox.Show("Please enter your important date");
                return;
            }
            else if (DateTime.TryParse(textBoxDate.Text, out ImportantDate) == false)
            {
                MessageBox.Show("Enter the date in the format DD/MM/YYYY");
                textBoxDate.Clear();
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("Please enter your important name");
                    return;
                }
                else
                {
                    ImportantName = textBoxName.Text.ToUpper();
                    if (string.IsNullOrWhiteSpace(textBoxPlace.Text))
                    {
                        MessageBox.Show("Please enter your important place");
                        return;
                    }
                    else
                    {
                        ImportantPlace = textBoxPlace.Text.ToUpper();
                        Form6 form6 = new Form6(UserFname, UserSname, DOB, ImportantDate, ImportantName, ImportantPlace);
                        form6.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
