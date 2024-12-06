namespace DoorGame
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
            bool WantsToPlayAnotherRound = true;

            do
            {
                Game game = new Game();
                Console.WriteLine();
                Console.Write("Do you wanna play again? (Yes/No) ");
                YesNo input = (YesNo)Enum.Parse(typeof(YesNo), Console.ReadLine());

                if (input.HasFlag(YesNo.No))
                    WantsToPlayAnotherRound = false;

                Console.Clear();
            } while (WantsToPlayAnotherRound);

            Console.WriteLine("end of program.");
        }
    }
}
