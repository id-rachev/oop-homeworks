using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Humans
{
    class Student: Human
    {
        double grade;

        public double Grade
        {
            get { return this.grade; }
        }

        public Student(string fName, string lName, double grade)
            : base(fName, lName)
        {
            this.grade = grade;
        }
    }
}
