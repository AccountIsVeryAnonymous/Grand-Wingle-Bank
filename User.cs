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
        public long UserID { get; set; }
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
            UserID = Convert.ToInt64(row["UserID"].ToString());
            DOB = DateTime.Parse(row["DOB"].ToString());
            Hash = (byte[])row["Hash"];
            Date = DateTime.Parse(row["Date"].ToString());
            Place = row["Place"].ToString();
            Name = row["Name"].ToString();
            // Safely parse LockedTime: handle DBNull and invalid formats without throwing
            LockedTime = null;
            object lockedObj = row["LockedTime"];
            if (lockedObj != DBNull.Value)
            {
                DateTime tmp;
                if (DateTime.TryParse(lockedObj.ToString(), out tmp))
                {                                    
                    LockedTime = tmp;
                }
            }
            UserForename = row["UserForename"].ToString();
            UserSurname = row["UserSurname"].ToString();
        }
        public User (string UserForename, string UserSurname, DateTime DOB, DateTime Date, string Place, string Name)
        {
            this.UserForename = UserForename;
            this.UserSurname = UserSurname;
            this.DOB = DOB;
            this.Date = Date;
            this.Place = Place;
            this.Name = Name;
        }
    }
}
