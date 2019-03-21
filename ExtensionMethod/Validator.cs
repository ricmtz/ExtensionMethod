using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class Validator
    {
        private static bool ValidateString(this string str, char[] specialChars, Func<char, bool> fn, bool acceptSpace = true)
        {
            bool result = false;
            List<char> tempStr = str.ToList();

            if (acceptSpace)
            {
                tempStr.RemoveAll(c => c == ' ');
            }
            if (specialChars != null)
            {
                tempStr.RemoveAll(c => specialChars.Contains(c));
            }

            result = tempStr.All(c => fn(c));

            return result;
        }

        public static bool ValidateAlphabeticString(this string str, char[] specialChars, bool acceptSpace = true)
        {
            return str.ValidateString(specialChars, char.IsLetter, acceptSpace);
        }

        public static bool ValidateAlphanumericString(this string str, char[] specialChars, bool acceptSpace = true)
        {
            return str.ValidateString(specialChars, char.IsLetterOrDigit, acceptSpace);
        }

        public static bool ValidateNumericString(this string str, char[] specialChars, bool acceptSpace = true)
        {
            return str.ValidateString(specialChars, char.IsDigit, acceptSpace);
        }
    }
}
