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
    public partial class Form13 : Form
    {
        private long UserID;
        public Form13(long ID)
        {
            InitializeComponent();
            UserID = ID;
        }
        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(UserID);
            form4.Show();
            this.Close();
        }
    }
}
