namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            List<Student> students = new List<Student>()
            {
                new("Pepijn", 1, 9.4),
                new("Dirk", 2, 5.4),
                new("Claudia", 3, 3.4)
            };
        }

        public void DisplayAllStudents(List<Student> students)
        {
            foreach (Student student in students) {
                Console.WriteLine(student);
            }
        }
    }
}
