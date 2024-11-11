using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class User
    {

        public string Username;

        private string _password;

            

        public string Password
        {

            get
            {
                return _password;
            } 
            set
            {
                PasswordValidator passwordValidator = new PasswordValidator();
                if (passwordValidator.isValid(value))
                    _password = value;
                else
                   return;

            }

        }

        public string Email;

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public override string ToString()
        {
            return $"(User details: \nUsername: {Username}     \r\nPassword: {Password} \r\nEmail: {Email}";
        }
    }
}
