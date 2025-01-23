using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShipper
{
    public class Log
    {
        const string PathToSuccessLogFile = "../../../success.txt";
        const string PathToErrorLogFile = "../../../error.txt";

        public void Success(string message)
        {
            WriteToLogFile(PathToSuccessLogFile, message);
        }

        void WriteToLogFile(string path, string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                    sw.WriteLine(message);
            }
            catch( IOException ex)
            {
                Console.WriteLine($"Error: Unable to open or write to this {path}!");
            }
        }

        public void Error(string message)
        {
            WriteToLogFile(PathToErrorLogFile, message);
        }
    }
}
