namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            StudentManager studentManager = new StudentManager();

            studentManager.AddStudentToClass(1, "Dirk", 15);
            studentManager.AddStudentToClass(2, "Jan", 14);
            studentManager.AddStudentToClass(3, "Piet", 16);
            studentManager.AddStudentToClass(4, "Fred", 13);
            studentManager.AddStudentToClass(5, "Freddie", 14);
            studentManager.AddStudentToClass(6, "Jantje", 15);
            studentManager.AddStudentToClass(7, "Bob", 17);

            studentManager.GiveStudentGrade(7, 10);
            studentManager.GiveStudentGrade(7, 7);
            studentManager.GiveStudentGrade(5, 4);
            studentManager.GiveStudentGrade(3, 3);
            studentManager.GiveStudentGrade(1, 9);
            studentManager.GiveStudentGrade(1, 10);

            studentManager.DisplayClassAverageGrade();
            studentManager.DisplayClassDetails();
            studentManager.RemoveStudentFromClass(4);
            studentManager.DisplayClassDetails();
        }
    }
}
