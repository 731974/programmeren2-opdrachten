namespace Classes
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
            //Abstract
            Wolf wolf = new Wolf();
            wolf.Sleep(); //->(): Wolf is sleeping

            wolf.MakeSound(); //->(): Woof, woof!

            //Interface
            Developer dev = new();
            dev.AssignProject(); //->():  Developer was assigned to project.

            Manager mnr = new(); 
            mnr.AssignProjectGroup(); //->():  Developer was assigned to project group.
            mnr.FireDeveloper(); //->():  Employee fired

            //Virtual
            WorkBreak wbreak = new("Dirk", "IT");
            wbreak.DisplayAction();
            FeedingAnimals fa = new("Dirk", "IT", "Lions");
            fa.DisplayAction();
        }
    }
}
