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
    public partial class Form2 : Form
    {
        private string UserForename;
        private string UserSurname;
        private DateTime DOB;
        public Form2()
        {
            InitializeComponent();

        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            UserForename = textBoxFirstName.Text;
            UserSurname = textBoxLastName.Text;
            if (string.IsNullOrWhiteSpace(textBoxDOB.Text))
            {
                MessageBox.Show("Please enter your date of birth");
                return;
            }
            else if (DateTime.TryParse(textBoxDOB.Text, out DOB) == false)
            {
                MessageBox.Show("Invalid date of birth");
                textBoxDOB.Clear();
                return;
            }
            else if (DateTime.Now.Year - DOB.Year < 18)
            {
                MessageBox.Show("You must be at least 18 years old to create an account at the Grand Wingle Bank");
                return;
            }
            else
            {
                Form5 form5 = new Form5(UserForename, UserSurname, DOB);
                form5.Show();
                this.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
