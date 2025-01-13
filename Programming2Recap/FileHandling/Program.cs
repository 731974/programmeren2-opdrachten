namespace FileHandling
{
    internal class Program
    {
        const string Path = "../../../test.txt";

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {

            // 3 folders omhoog om files te bekijken ../../../

            StreamWriter sw = new StreamWriter(Path);
            sw.WriteLine("test");
            sw.Close();

            // Kan ook via de using; (VOORBEELD) het sluit automatisch

            using(StreamWriter sw2 = new StreamWriter(Path, true)) //True = toevoegen - False or " " is overschrijven
                sw2.WriteLine("test");

            StreamReader sr = new StreamReader(Path);

            while(!sr.EndOfStream)
                Console.WriteLine(sr.ReadLine());
        }
    }
}
