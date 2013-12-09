using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Cat: Animal, ISound
    {
        public Cat(double age, string name, AnimalSex sex)
            : base(age, name, sex)
        {
        }

        public string ProduceSound()
        {
            return "Mew";
        }
    }
}
