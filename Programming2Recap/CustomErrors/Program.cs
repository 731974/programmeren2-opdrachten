namespace CustomErrors
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

            // Je kan je eigen errors maken door een class te maken en die te laten overerven van Exception

            try
            {

                throw new OutOfEnergy("Out Of Energy");

            }
            catch (OutOfEnergy e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
