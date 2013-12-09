using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, bool isFemale)
            : base(name, age, isFemale)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Bauu-bauu!");
        }
    }
}
