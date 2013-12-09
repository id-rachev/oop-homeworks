using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Animals
{
    enum AnimalSex
    {
        male,
        female
    }

    abstract class Animal
    {
        public double Age {get; set;}
        public string Name { get; set; }
        AnimalSex sex;

        public Animal (double age, string name, AnimalSex sex)
        {
            this.Age = age;
            this.Name = name;
            this.sex = sex;
        }

        public override string ToString()
        {
            return String.Format("{0} is {1} and is {2} year old.", this.Name, this.sex, this.Age); ;
        }
    }
}
