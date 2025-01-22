namespace OnlineShop
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

            AccountManager am = new("../../../records.txt");

            am.SaveAccount(new Admin("Timo", "Password123", "Designer"));

            am.SaveAccount(new Customer("Dirk", "P@ssw0rd", 1));

            am.ShowAccounts();

            am.DeleteAccount(new Admin("Timo", "Password123", "Designer"));

            am.ShowAccounts();
        }
    }
}
