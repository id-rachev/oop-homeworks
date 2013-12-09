using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Kitten: Cat, ISound
    {
        public Kitten(double age, string name, AnimalSex sex)
            : base(age, name, sex)
        {
            if (sex != AnimalSex.female)
            {
                throw new ArgumentException("Kittens are female cats!");
            }
        }
    }
}
