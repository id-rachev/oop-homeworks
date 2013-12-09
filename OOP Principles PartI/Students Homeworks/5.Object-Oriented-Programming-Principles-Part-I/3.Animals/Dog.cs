using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Dog: Animal, ISound
    {
        public Dog(double age, string name, AnimalSex sex)
            : base(age, name, sex)
        {
        }

        public string ProduceSound()
        {
            return "Wow-wow.";
        }
    }
}
