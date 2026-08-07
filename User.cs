using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Wingle_Bank
{
    internal class User
    {
        public int UserID { get; set; }
        public DateTime DOB { get; set; }
        public byte[] Hash { get; set; }
        public DateTime Date { get; set; }
        public string Place {  get; set; }
        public string Name { get; set; }
        public DateTime? LockedTime { get; set; }
        public string UserForename { get; set; }
        public string UserSurname { get; set; }
        public User(DataRow row)
        {
            UserID = int.Parse(row["UserID"].ToString());
            DOB = DateTime.Parse(row["DOB"].ToString());
            Hash = (byte[])row["Hash"];
            Date = DateTime.Parse(row["Date"].ToString());
            Place = row["Place"].ToString();
            Name = row["Name"].ToString();
            LockedTime = DateTime.Parse(row["LockedTime"].ToString());
            UserForename = row["UserForename"].ToString();
            UserSurname = row["UserSurname"].ToString();
        }
    }
}
