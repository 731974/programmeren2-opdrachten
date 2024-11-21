using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class User
    {
        private PasswordValidator passwordValidator = new PasswordValidator();
        
        public string Username { get; set; }

        private string _password;

        public string Password
        {

            get
            {
                return _password;
            } 
            set
            {
                if (passwordValidator.isValid(value))
                    _password = value;
                return;

            }
        }

        public string Email { get; set; }

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
