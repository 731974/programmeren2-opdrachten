using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class UserManagementService
    {
        User[] users = new User[10];
        int userCount = 0;
        private UserRegistration userRegistration = new UserRegistration();

        public void AddUser()
        {
            User user = userRegistration.RegisterUser();

            if (user != null && userCount < users.Length)
            {
                users[userCount] = user;
                userCount++;
            }
            else
            {
                if(userCount > users.Length) Console.WriteLine("Totale capaciteit overschreden");
                if (user == null) return;
            }
        }
    }
}
