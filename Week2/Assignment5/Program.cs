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

            Zoo zoo = new Zoo();

            //For 5
            //zoo.DisplayAnimalDetails(lion);
            //zoo.DisplayAnimalDetails(elephant);

            ZooKeeper zooKeeper = new ZooKeeper();

            Animal[] animals = new Animal[2];
            animals[0] = lion;
            animals[1] = elephant;

            zooKeeper.FeedAnimals(animals);
            zoo.MakeAllAnimalsSound(animals);
        }
    }
}
