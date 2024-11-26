namespace Assignment5to7
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
            Lion lion = new Lion("Simba");
            Elephant elephant = new Elephant("Dumbo");

            Zoo zoo = new();
            ZooKeeper zooKeeper = new();
            
            Animal[] animals = { lion , elephant };

            zooKeeper.FeedAnimals(animals);
            zoo.MakeAllAnimalsSound(animals);
        }
    }
}