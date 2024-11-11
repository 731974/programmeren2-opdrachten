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

            if (password.Length < 8)
            {
                return false;
            }
            else
            {


                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        hasUppercase = true;
                    }
                    else if (char.IsNumber(password[i]))
                    {
                        hasNumber = true;
                    }
                }

                if (hasNumber == true && hasUppercase == true)
                    return true;
                else
                    return false;
            }
        }
    }
}
