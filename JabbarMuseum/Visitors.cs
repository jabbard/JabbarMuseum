using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabbarMuseum
{
    public class Visitors
    {
        public int CardNo { get; set; }
        public String Name { get; set; }
        public String PhNo { get; set; }
        public String Occupation { get; set; }
        public String Gender { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DayOfWeek Day { get; set; }

        public Visitors(int CardNo, String Name, String PhNo, String Occupation, String Gender, DateTime InTime, DayOfWeek Day)
        {
            this.CardNo = CardNo;
            this.Name = Name;
            this.PhNo = PhNo;
            this.Occupation = Occupation;
            this.Gender = Gender;
            this.InTime = InTime;
            this.Day = Day;
        }
    }
}
