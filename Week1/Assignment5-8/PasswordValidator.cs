using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class PasswordValidator
    {
        public bool isValid(string password)
        {
            bool hasNumber = false;
            bool hasUppercase = false;
            bool hasLowercase = false;

            foreach (char c in password)
            {
                if (hasLowercase && hasNumber && hasUppercase)
                    break;
                

                if (char.IsUpper(c))
                    hasUppercase = true;
                else if (char.IsNumber(c))
                    hasNumber = true;
                else if (char.IsLower(c))
                    hasLowercase = true;
            }

            return (hasLowercase && hasNumber && hasUppercase && password.Length >= 8);
        }
    }
}
