using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputStr;
            Console.WriteLine("Write a sentense:");
            inputStr = Console.ReadLine();
            if (inputStr.ValidateAlphabeticString(null)) {
                Console.WriteLine("'{0}' is a valid Alphabetic string", inputStr);
            } else {
                Console.WriteLine("'{0}' is not a valid Alphabetic string", inputStr);
            }
            if (inputStr.ValidateAlphanumericString(null)) {
                Console.WriteLine("'{0}' is a valid Alphanumeric string", inputStr);
            } else {
                Console.WriteLine("'{0}' is not a valid Alphanumeric string", inputStr);
            }
            if (inputStr.ValidateNumericString(null)) {
                Console.WriteLine("'{0}' is a valid Numeric string", inputStr);
            } else {
                Console.WriteLine("'{0}' is not a valid Numeric string", inputStr);
            }
            Console.Read();
        }
    }
}
