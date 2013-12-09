using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplinesSet;

        public List<Discipline> DisciplinesSet
        {
            get
            {
                return this.disciplinesSet;
            }
            set
            {
                this.disciplinesSet = value;
            }
        }

        public Teacher(string name)
            : this(name, new List<Discipline>())
        {

        }

        public Teacher(string name, List<Discipline> disciplineSet)
            : base(name)
        {
            this.DisciplinesSet = disciplineSet;
        }
    }
}
