using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class UserRegistration
    {
        private PasswordValidator passwordValidator = new PasswordValidator();

        public User RegisterUser()
        {
            Console.Write("Enter your username; ");
            string username = Console.ReadLine();
            Console.Write("Enter your password; ");
            string password = Console.ReadLine();
            Console.Write("Enter your email; ");
            string email = Console.ReadLine();
            
            bool isStrongPassword = passwordValidator.isValid(password);
            if (isStrongPassword)
            {
                User user = new(username, password, email);
                Console.WriteLine("User registered successfully!");
                return user;
            }
            Console.WriteLine("Password is too weak. It must be at least 8 characters long and contain an uppercase letter and a number.");
            return null;
        }
    }
}
