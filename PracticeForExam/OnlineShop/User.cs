using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public abstract class User
    {
        public string Username { get; }
        public string Password { get; }

        public User(string username, string password) {
            Username = username;
            Password = password;
        }

        public virtual string SaveFormat()
        {
            return $"{base.GetType().Name}|{Username}|{Password}";
        }

        public virtual string ShowDetails()
        {

            return $"Username: {Username}\nPassword: {Password}";

        }
    }
}
