using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IEmployee
    {

        void AssignProject();
        void AssignProjectGroup();

    }

    public class Developer : IEmployee
    {
        // Omdat Developer overerft van IEmployee, moet deze alle methods invullen van de interface!

        public void AssignProject()
        {
            Console.WriteLine("Developer was assigned to project.");
        }

        public void AssignProjectGroup()
        {
            Console.WriteLine("Developer was assigned to project group.");
        }
    }

    public class Manager : Developer { 
    
        // Manager erft over van Developer en hoeft dus niet opnieuw de IEmployee te definiëren, automatisch
        // zijn dan ook de methods verbonden met de Manager class. 

        public void FireDeveloper()
        {

            Console.WriteLine("Employee fired");

        }
        
    } 
}


