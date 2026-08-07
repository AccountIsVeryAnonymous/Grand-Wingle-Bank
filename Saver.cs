using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Wingle_Bank
{
    internal class Saver
    {
        public int UserID { get; set; }
        public decimal TotalBalance { get; set; }
        public DateTime DateOpened { get; set; }
        public Saver(DataRow row)
        {
            UserID = int.Parse(row["UserID"].ToString());
            TotalBalance = decimal.Parse(row["TotalBalance"].ToString());
            DateOpened = DateTime.Parse(row["DateOpened"].ToString());
        }
    }
}
