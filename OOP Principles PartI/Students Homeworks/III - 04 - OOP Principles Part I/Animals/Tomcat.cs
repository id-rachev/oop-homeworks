using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, string sex,string sound)
            : base(age,name,sex,sound)
        {
            this.sex = "male";
            this.sound = sound;
        }

         
        public override string Sound()
        {
            return this.sound;

        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Tom name: " + this.name);
            info.AppendLine("Tom age: " + this.age);
            info.AppendFormat("Tom sex: " + this.sex);
            info.AppendFormat("Tom sound like: {0}", Sound());


            return info.ToString();
        }
    }
}
