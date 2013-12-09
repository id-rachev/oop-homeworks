using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class School
    {
        public string Name { get; private set; }
        public List<SchoolClasses> Classes { get; private set;}

        public School(string name, SchoolClasses[] classes)
        {
            this.Name = name;
            this.Classes = new List<SchoolClasses>(classes);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("School name:" + this.Name+"\n");
            foreach (var item in Classes)
            {
                sb.AppendLine(item.ToString());    
            }
            return Convert.ToString(sb);
        }
    }

