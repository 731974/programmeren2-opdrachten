using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5to7
{
    public class Person
    {

        public string Name { get; set; }
        public int MembershipID { get; set; }

        public Person(string name, int membershipID)
        {
            Name = name;
            MembershipID = membershipID;
        }

    }
}
