using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, byte age, bool isFemale)
            : base(name, age, isFemale)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Myaauu!");
        }
    }
}
