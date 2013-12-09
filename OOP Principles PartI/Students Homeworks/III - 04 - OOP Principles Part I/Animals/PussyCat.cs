using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class PussyCat : Cat
    {
        public PussyCat(int age, string name, Sex sex, string sound)
            : base(age, name, sex, sound)
        {
            this.sound = sound;
        }

         
        public override string Sound()
        {
            return this.sound;

        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("PussyCat name: " + this.name);
            info.AppendLine("PussyCat age: " + this.age);
            info.AppendFormat("PussyCat sex: " + this.sex);
            info.AppendFormat("PussyCat sound like: {0}", Sound());


            return info.ToString();
        }
    }
}
