namespace Assignment58
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



            // 5. Don't change the code below, you can uncomment the code after finishing assignment 5

            //User user = new User("AliceCooper", "NotSoSafe123!", "alice.cooper@example.com");
            //Console.WriteLine(user);


            // 6. Don't change the code below, you can uncomment the code after finishing assignment 6
            //UserRegistration userRegistration = new UserRegistration();
            //User user = userRegistration.RegisterUser();



            // 7. Don't change the code below, you can uncomment the code after finishing assignment 7
            UserManagementService userManagementService = new UserManagementService();
            userManagementService.AddUser();


        }
    }
}
