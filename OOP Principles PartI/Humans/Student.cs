using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Student : Human
    {
        private float grade;

        public float Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if ((value < 1) || (value > 6))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.grade = value;
            }
        }

        public Student(string firstName)
            : this(firstName, null, 0.0f)
        {
        }

        public Student(string firstName, string lastName, float grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
