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
    public partial class Form6 : Form
    {
        private DateTime DOB;
        private DateTime Date;
        private string Name;
        private string Place;
        private string UserID;
        private string Passcode;
        private Random RNG = new Random();
        public Form6(string UserForename, string UserSurname, DateTime DateOfBirth, DateTime ImportantDate, string ImportantName, string ImportantPlace)
        {
            InitializeComponent();
            DOB = DateOfBirth;
            Date = ImportantDate;
            Name = ImportantName;
            Place = ImportantPlace;
            for (int i = 1; i <= 12; i++)
            {
                UserID = Convert.ToString(RNG.Next(1, 10));
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
