using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Dog:Animal
    {
         
        public Dog(string name, byte age, Sex sex)
            : base(name, age, sex)
        {
 
        }
        public override string ToString()
        {
            StringBuilder doginfo = new StringBuilder();
            doginfo.AppendFormat("{0} i am a {1}",base.ToString(),this.GetType().Name);
            return Convert.ToString(doginfo);
        }
        public  override void MakeSound()
        {
            Console.WriteLine("Uaf");
        }
    }

