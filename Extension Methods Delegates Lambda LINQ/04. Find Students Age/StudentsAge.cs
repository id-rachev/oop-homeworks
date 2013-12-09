using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Students;

namespace _04.Find_Students_Age
{
    public class StudentsAge : Student
    {        
        private int age;

        public StudentsAge(string firstName, string lastName, int age)
            : base(firstName, lastName)
        {
            this.Age = age;
        }

        public int Age
        {
            get
            { return this.age;  }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
