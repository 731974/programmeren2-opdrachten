using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member : Person
    {
        public int Id { get; }

        Dictionary<int, Item> listOfReadBooks = new Dictionary<int, Item>();

        public Member(string name, int age, int memberId) : base(name, age)
        {
            Id = memberId;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Member Id: {Id}");
        }

        public override void GetRole()
        {
            Console.WriteLine($"Members don't have roles!");
        }

    }
}
