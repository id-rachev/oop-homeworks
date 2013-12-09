using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {

        public int age { get; set; }
        public string name { get; set; }
        public Sex sex { get; set; }
        public string sound { get; set; }

        public Animal(int age, string name, Sex sex)
        {
            this.age = age;
            this.name = name;
            this.sex = sex;
        }

   

        public abstract string Sound ();
    }
}
