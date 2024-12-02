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

            List<Student> students = new List<Student>();

            Student Pepijn = new("Pepijn", 1, 9.4);
            students.Add(Pepijn);

            Student Dirk = new("Dirk", 2, 5.4);
            students.Add(Dirk);

            Student Claudia = new("Claudia", 3, 3.4);
            students.Add(Claudia);
        }

        public void DisplayAllStudents(List<Student> students)
        {
            foreach (Student student in students) {
                Console.WriteLine(student);
            }
        }
    }
}
