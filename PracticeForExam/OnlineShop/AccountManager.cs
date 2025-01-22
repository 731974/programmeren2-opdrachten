using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class AccountManager
    {
        private string _pathToFiles;
        public List<User> Users { get; }

        public AccountManager(string path)
        {
            _pathToFiles = path;
            Users = InitAccount(_pathToFiles);
        }


        public void ShowAccounts()
        {
            foreach (User user in Users)
                Console.WriteLine(user.ShowDetails());
        }

        public User FindUserByBasketId(int basketId)
        {

            foreach (Customer user in Users)
                if (user.BasketId == basketId)
                    return user;
                else
                    throw new UserNotFound("Error: User was not found in our database!");
        
        }

        public void SaveAccount(User user)
        {
            if (user == null)
                throw new AccountCannotBeNull("Error: Account is equal to null");

            string userSaveFormat = user.SaveFormat();
            bool userExists = false;

            if (File.Exists(_pathToFiles))
            {
                using (StreamReader sr = new StreamReader(_pathToFiles))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == userSaveFormat)
                        {
                            userExists = true;
                            break;
                        }
                    }
                }
            }

            if (!userExists)
            {
                using (StreamWriter sw = new StreamWriter(_pathToFiles, true))
                {
                    sw.WriteLine(userSaveFormat);
                }
            }
        }

        public void DeleteAccount(User user)
        {
            List<User> usersToSave = new List<User>();

            using (StreamReader sr = new StreamReader(_pathToFiles))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "")
                        continue;

                    string[] parts = line.Split("|");

                    if (parts[1] != user.Username)
                    {
                        if (parts[0] == "Admin")
                            usersToSave.Add(new Admin(parts[1], parts[2], parts[3]));
                        else if (parts[0] == "Customer")
                            usersToSave.Add(new Customer(parts[1], parts[2], int.Parse(parts[3])));
                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(_pathToFiles))
            {
                sw.WriteLine("");
            }

            using (StreamWriter sw = new StreamWriter(_pathToFiles, true))
            {
                foreach (User u in usersToSave)
                {
                    sw.WriteLine(u.SaveFormat());
                }
            }

            Users.Remove(user);
        }

        public List<User> InitAccount(string path)
        {
            List<User> users = new List<User>();

            try
            {
                using (StreamReader sw = new StreamReader(_pathToFiles))
                {
                    while (!sw.EndOfStream)
                    {
                        string line = sw.ReadLine();

                        if(line == "")
                            continue;

                        string[] parts = line.Split("|");

                        if (parts[0] == "Admin")
                            users.Add(new Admin(parts[1], parts[2], parts[3]));
                        else if (parts[0] == "Customer")
                            users.Add(new Customer(parts[1], parts[2], int.Parse(parts[3])));
                        else
                            throw new ErrorRetrievingAccountFromSave("Error: Account type not recognized");
                    }
                }

                
            }
            catch (IOException ex) {

                Console.WriteLine("Cannot access records.txt before its creation");
                
            }
            catch (ErrorRetrievingAccountFromSave ex)
            {
                Console.WriteLine(ex.Message);
            }

            return users;
        }
    }
}
