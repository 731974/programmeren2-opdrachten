namespace List
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

            List<char> alreadyEntered = new List<char>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Attempt {i+1}: ");
                ReadLetter(alreadyEntered);
                PrintAllLetters(alreadyEntered);
            }

        }

        void PrintAllLetters(List<char> alreadyEntered)
        {
            Console.WriteLine("The already entered letters are: ");

            foreach (char c in alreadyEntered) {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }

        char ReadLetter(List<char> alreadyEntered)
        {
            char letter;
            do
            {

                Console.Write("Enter a letter: ");
                letter = Console.ReadLine()[0];

            }
            while (alreadyEntered.Contains(letter));
            alreadyEntered.Add(letter);

            return letter;

        }
    }
}
