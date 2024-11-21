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
            Console.Write("Enter the length of the Rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of the Rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Length = length;

            Console.WriteLine($"Area of rectangle is: {rectangle.Area}");
        }
    }
}
