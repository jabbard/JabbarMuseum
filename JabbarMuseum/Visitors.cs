using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JabbarMuseum
{
    class Visitors
    {
        private int CardNo { get; set; }
        private String Name { get; set; }
        private String PhNo { get; set; }
        private String Occupation { get; set; }
        private String Gender { get; set; }
        private String Address { get; set; }
        private DateTime InTime { get; set; }
        private DateTime OutTime { get; set; }

        public Visitors(int CardNo, String Name, String PhNo, String Occupation, String Gender, String Address, DateTime InTime)
        {
            this.CardNo = CardNo;
            this.Name = Name;
            this.PhNo = PhNo;
            this.Occupation = Occupation;
            this.Gender = Gender;
            this.Address = Address;
            this.InTime = InTime;
        }
    }
}
