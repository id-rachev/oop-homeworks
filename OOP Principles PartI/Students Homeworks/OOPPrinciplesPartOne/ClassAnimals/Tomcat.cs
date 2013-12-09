using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Tomcat:Cat
    {
        public Tomcat(string name, byte age, Sex sex):base(name, age,Sex.Male){} //set sex male for all tomcats

        public override string ToString()
        {
            StringBuilder tomcatInfo = new StringBuilder();
            tomcatInfo.AppendFormat("{0} i am a {1}", base.ToString(), this.GetType().Name);
            return Convert.ToString(tomcatInfo); 
        }
        public override void MakeSound()
        {
            Console.WriteLine("Muay");
        }
    }

