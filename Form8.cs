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
    public partial class Form8 : Form
    {
        private long AccountNumber = 0;
        private long ID = 0;
        public Form8(long AccountNumber, long UserID)
        {
            this.AccountNumber = AccountNumber;
            ID = UserID;
            InitializeComponent();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(ID);
            form4.Show();
            this.Close();
        }
        private void comboBoxPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPerson.SelectedItem.ToString() == "Your own account")
            {
                MessageBox.Show("If you are being asked to transfer money to your account, this is a scam. Press the main menu button to cancel the payment");
            }
            else
            {
                comboBoxDetails.Items.Add("Email");
                comboBoxDetails.Items.Add("Phone call");
                comboBoxDetails.Items.Add("Text message");
                comboBoxDetails.Items.Add("In person");
                comboBoxDetails.Items.Add("Social media");
            }
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            comboBoxPerson.Items.Add("Select to continue");
            comboBoxPerson.Items.Add("Your own account");
            comboBoxPerson.Items.Add("Friend or family");
            comboBoxPerson.Items.Add("Tradesperson");
            comboBoxPerson.Items.Add("House purchase or rent");
            comboBoxPerson.Items.Add("Bill or invoice");
            comboBoxPerson.Items.Add("Cryptocurrency");
            comboBoxPerson.Items.Add("Investment");
        }

        private void comboBoxDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPerson.SelectedItem.ToString() == "Friend or family")
            {
                if(comboBoxDetails.SelectedItem.ToString() == "In person")
                {
                    textBoxWarning.Text = "A criminal can make friends with you online then ask you for money ";
                }
                else
                {
                    textBoxWarning.Text = "A criminal can impersonate a trusted person online then ask you for money";
                }
            }
            else if (comboBoxPerson.SelectedItem.ToString() == "Tradesperson")
            {
                textBoxWarning.Text = "Dishonest trade companies make you pay for a job they won't finish";
            }
            else if (comboBoxPerson.SelectedItem.ToString() == "House purchase or rent")
            {
                textBoxWarning.Text = "A criminal can offer places to buy or rent you won't get access to";
            }
            else if (comboBoxPerson.SelectedItem.ToString() == "Bill or invoice")
            {
                textBoxWarning.Text = "A criminal can impersonate a genuine company and send invoices";
            }
            else if (comboBoxPerson.SelectedItem.ToString() == "Cryptocurrency")
            {
                textBoxWarning.Text = "Criminals ask you to exchange their money into cryptocurrency so you can send it to them";
            }
            else if (comboBoxPerson.SelectedItem.ToString() == "Investment")
            {
                textBoxWarning.Text = "Criminals set up fake investment opportunities or pretend to work for real ones";
            }
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
