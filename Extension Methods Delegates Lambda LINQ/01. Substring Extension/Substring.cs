using System;
using System.Linq;
using System.Text;

namespace _01.Substring_Extension
{
    public static class Substring
    {
        public static StringBuilder SubStringBuilder(this StringBuilder someString, int index, int length)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                newString.Append(someString[index + i]);
            }
            return newString;
        }
    }
}
