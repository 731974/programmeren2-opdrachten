namespace Assignment3
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

            Console.Write("Enter the Length of the Rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of the Rectangle: ");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.Width = length;
            rectangle.Length = height;

            Console.WriteLine($"Area of rectangle is: {rectangle.Area}");

        }
    }
}
