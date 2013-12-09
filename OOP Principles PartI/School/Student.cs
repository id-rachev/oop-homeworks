using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        public ushort ClassNumber { get; set; }

        public Student(string name, ushort classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }
    }
}
