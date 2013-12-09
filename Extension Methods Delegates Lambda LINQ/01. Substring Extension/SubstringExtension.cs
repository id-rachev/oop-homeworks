using System;
using System.Linq;
using System.Text;

namespace _01.Substring_Extension
{
    // Implement an extension method Substring(int index, int length)
    // for the class StringBuilder that returns new StringBuilder
    // and has the same functionality as Substring in the class String.

    class SubstringExtension
    {
        static void Main()
        {
            string str = "Doncho programista";
            Console.WriteLine(str.Substring(7, 4)); // "prog"

            StringBuilder someString = new StringBuilder("Doncho");
            someString.Append(" programista");

            Console.WriteLine(someString.SubStringBuilder(7, 4)); // "prog"
        }
    }
}
