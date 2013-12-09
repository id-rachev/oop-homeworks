using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, byte age, bool isFemale)
            : base(name, age, isFemale)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("Kuwaa-kuwaa!");
        }
    }
}
