using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
   public abstract class Person : ICommentable
    {
        private string name;

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if ((value.Length < 2) || (value.Length > 30))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.name = value;
            }
        }

        public List<string> Comments { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }
    }

}
