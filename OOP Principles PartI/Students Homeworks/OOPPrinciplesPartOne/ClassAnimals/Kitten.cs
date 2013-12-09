using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Kitten:Cat
    {
        public Kitten(string name, byte age, Sex sex):base(name, age,Sex.Female){} //set sex female for all kittens

        public override string ToString()
        {
            StringBuilder kittenInfo = new StringBuilder();
            kittenInfo.AppendFormat("{0} i am a {1}",base.ToString(),this.GetType().Name);
            return Convert.ToString(kittenInfo); 
        }
        public override void MakeSound()
        {
            Console.WriteLine("Muay");
        }
    }

