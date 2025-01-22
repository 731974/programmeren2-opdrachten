using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Staff : Person
    {

        public int Id { get; }
        public string Role { get; }
        public Staff(string name, int age, int id, string role) : base(name, age)
        {
            Role = role;
            Id = id;
        }

        public override void GetRole()
        {

            Console.WriteLine($"Current position is {Role}");

        }
    }
}
