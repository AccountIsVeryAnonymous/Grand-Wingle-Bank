using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Wingle_Bank
{
    internal class Account
    {
        public int UserID { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal CurrentAccountBalance { get; set; }
        public decimal? SaverBalance { get; set; }
        public int? SaverNumber { get; set; }
        public int AccountNumber { get; set; }
        public Account(DataRow row)
        {
            UserID = int.Parse(row["UserID"].ToString());
            TotalBalance = decimal.Parse(row["TotalBalance"].ToString());
            CurrentAccountBalance = decimal.Parse(row["CurrentAccountBalance"].ToString());
            SaverBalance = decimal.Parse(row["SaverBalance"].ToString());
            SaverNumber = int.Parse(row["SaverNumber"].ToString()); 
            AccountNumber = int.Parse(row["AccountNumber"].ToString());
        }
    }
}
