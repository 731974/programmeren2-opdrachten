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
            Circle circle = new(5);
            Console.WriteLine(circle.GetShapeInfo());

            Rectangle rectangle = new(50, 50);
            Console.WriteLine(rectangle.GetShapeInfo()); 
        }
    }
}