using System;

namespace Assignment2
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
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.WriteLine(); //whiteline

            Book book = new(title, author);
            Console.WriteLine(book.ToString());
        }
    }
}
