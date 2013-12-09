using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Animal:ISound
    {
        public string Name { get; private set; }
        public byte Age { get; private set; }
        public Sex Sex { get; private set; }

        protected Animal(string name, byte age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        public override string ToString()
        {
            StringBuilder animalInfo = new StringBuilder();
            animalInfo.Append(this.Name + " " + this.Age + " " + this.Sex);
            return Convert.ToString(animalInfo);
        }
       virtual public void MakeSound()
        {
            Console.WriteLine();
        }
       public static void CalculateAge(Animal[] animals)
       {
           var animalAge =
               from res in animals
               group res by res.GetType() into ages
               select new Tuple<string,double>(ages.Key.Name,ages.Average(a=>a.Age));
           foreach (var item in animalAge)
           {
               Console.WriteLine("Average age for:{0} is {1:N1}:",item.Item1,item.Item2);
           }
       }
       
    }

