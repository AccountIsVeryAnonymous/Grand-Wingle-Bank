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
        int ID = 0;
        public Form4(int UserID)
        {
            InitializeComponent();
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Harve\OneDrive\Pictures\Screenshots 1\GrandWingleBankLogo.png");
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ID = UserID;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void buttonViewWingleAccount_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(ID);
            form7.Show();
            this.Close();
        }
    }
}