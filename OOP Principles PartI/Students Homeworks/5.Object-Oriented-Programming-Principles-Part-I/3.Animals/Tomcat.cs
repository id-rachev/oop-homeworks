using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    class Tomcat: Cat, ISound
    {
        public Tomcat(double age, string name, AnimalSex sex)
            : base(age, name, sex)
        {
            if (sex != AnimalSex.male)
            {
                throw new ArgumentException("Kittens are male cats!");
            }
        }
    }
}
