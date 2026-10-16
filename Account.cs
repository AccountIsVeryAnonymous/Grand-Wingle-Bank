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
        public long UserID { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal CurrentAccountBalance { get; set; }
        public decimal? SaverBalance { get; set; }
        public long? SaverNumber { get; set; }
        public long AccountNumber { get; set; }
        public Account(DataRow row)
        {
            UserID = Convert.ToInt64(row["UserID"].ToString());
            TotalBalance = decimal.Parse(row["TotalBalance"].ToString());
            CurrentAccountBalance = decimal.Parse(row["CurrentAccountBalance"].ToString());
            SaverBalance = decimal.Parse(row["SaverBalance"].ToString());
            SaverNumber = Convert.ToInt64(row["SaverNumber"].ToString()); 
            AccountNumber = Convert.ToInt64(row["AccountNumber"].ToString());
        }
    }
}