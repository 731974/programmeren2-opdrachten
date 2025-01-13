using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class StudentManager
    {

         Dictionary<int, Student> Class1A = new Dictionary<int, Student>();

        public void GiveStudentGrade(int id, int grade)
        {
            Class1A[id].Grades.Add(grade);
        }  

        public void DisplayClassAverageGrade()
        {
            int totalGrade = 0;

            foreach (KeyValuePair<int, Student> key in Class1A) 
                foreach(int grade in key.Value.Grades)
                    totalGrade += grade;

            Console.WriteLine(totalGrade / Class1A.Count);
        }
        
        public void DisplayClassDetails()
        {
            foreach (KeyValuePair<int, Student> kvp in Class1A) 
                kvp.Value.DisplayDetails();
        }

        public void AddStudentToClass(int id, string name, int age)
        {
            Class1A.Add(id, new(name, id, age));
        }

        public void RemoveStudentFromClass(int id)
        {
                if (Class1A.ContainsKey(id)) 
                    Class1A.Remove(id);
                else
                    Console.WriteLine($"Student with {id} doesn't exist!");
        }
    }
}
