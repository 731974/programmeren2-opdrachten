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

            Circle circle = new(50);
            circle.GetShapeInfo();

            Rectangle rectangle = new(50, 50);
            rectangle.GetShapeInfo();

        }
    }
}
