using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal : ISound
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public bool IsFemale { get; set; }

        public Animal(string name, byte age, bool isFemale)
        {
            this.Name = name;
            this.Age = age;
            this.IsFemale = isFemale;
        }

        public override void MakeSound()
        {
            Console.WriteLine("I'm just an animal!");
        }
    }
}
