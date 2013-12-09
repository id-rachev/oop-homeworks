using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[]
           {
               new Dog("Sharo",11,Sex.Male),
               new Dog("Balkan",3,Sex.Male),
               new Dog("Nora",2,Sex.Female),
               new Frog("Kikirica",2,Sex.Female),
               new Kitten("Pepa",5,Sex.Male),
               new Tomcat("Tom",5,Sex.Female),
                new Tomcat("Tom",8,Sex.Female),
           };
            foreach (var item in animal)
            {
                Console.Write("{0} ",item.ToString());
                item.MakeSound();
            }
            Animal.CalculateAge(animal);
        }
    }
}
