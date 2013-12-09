using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Animals
{
    class Program
    {
        static void Main()
        {
            //create animal from each type
            Dog dog = new Dog(2, "Rosi", AnimalSex.female);
            Console.WriteLine(dog.ToString());

            Frog frog = new Frog(6, "Froggy", AnimalSex.female);
            Console.WriteLine(frog.ToString());

            Cat cat = new Cat(4, "Misi", AnimalSex.female);
            Console.WriteLine(cat.ToString());

            Kitten kitten = new Kitten(1, "Kitty", AnimalSex.female);
            Console.WriteLine(kitten.ToString());

            Tomcat tomcat = new Tomcat(1, "Tommy", AnimalSex.male);           
            Console.WriteLine(tomcat.ToString());

            //create dog list and print calculated average age
            List<Dog> dogList = new List<Dog>();
            dogList.Add(dog);
            dogList.Add(new Dog(3, "Topcho", AnimalSex.male));
            dogList.Add(new Dog(2.5, "Sharo", AnimalSex.male));
            double dogAverageAge = dogList.Average((x) => x.Age);
            Console.WriteLine("Dogs average age is: {0}", dogAverageAge);

            //create frog list and print calculated average age
            List<Frog> frogList = new List<Frog>();
            frogList.Add(frog);
            frogList.Add(new Frog(3, "Jabcho", AnimalSex.male));
            frogList.Add(new Frog(5, "Greeny", AnimalSex.male));
            double frogAverageAge = frogList.Average((x) => x.Age);
            Console.WriteLine("Frogs average age is: {0}", frogAverageAge);

            //create cat list and print calculated average age
            List<Cat> catList = new List<Cat>();
            catList.Add(cat);
            catList.Add(new Cat(6, "Piksy", AnimalSex.female));
            catList.Add(new Cat(9, "Max", AnimalSex.male));
            double catAverageAge = catList.Average((x) => x.Age);
            Console.WriteLine("Cats average age is: {0}", catAverageAge);

            //megre all list and print calculated average age
            List<dynamic> mergedList = new List<dynamic>();
            foreach (var d in dogList)
            {
                mergedList.Add(d);
            }

            foreach (var f in frogList)
            {
                mergedList.Add(f);
            }

            foreach (var c in catList)
            {
                mergedList.Add(c);
            }

            double sum = 0;
            for (int i = 0; i < mergedList.Count; i++)
            {
                sum = sum + mergedList[i].Age;
            }
            double averageAge = sum / mergedList.Count;
            Console.WriteLine("All animals average age is: {0}", averageAge);
        }
    }
}
