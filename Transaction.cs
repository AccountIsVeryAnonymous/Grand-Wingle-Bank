using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Wingle_Bank
{
    internal class Transaction
    {
        public int AccountNumber { get; set; }
        public int ReceivingNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public decimal BalanceBefore { get; set; }
        public decimal BalanceAfter { get; set; }
        public decimal ReceivingBalanceBefore { get; set; }
        public decimal ReceivingBalanceAfter { get; set; }
        public Transaction(DataRow row)
        {
            AccountNumber = int.Parse(row["AccountNumber"].ToString());
            ReceivingNumber = int.Parse(row["ReceivingNumber"].ToString());
            Amount = decimal.Parse(row["Amount"].ToString());
            DateOfTransaction = DateTime.Parse(row["DateOfTransaction"].ToString());
            BalanceBefore = decimal.Parse(row["BalanceBefore"].ToString());
            BalanceAfter = decimal.Parse(row["BalanceAfter"].ToString());
            ReceivingBalanceBefore = decimal.Parse(row["ReceivingBalanceBefore"].ToString());
            ReceivingBalanceAfter = decimal.Parse(row["ReceivingBalanceAfter"].ToString());
        }

    }
}
