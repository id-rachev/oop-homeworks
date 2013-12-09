using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student:Human
    {
        private double grade;
        public double Grade { 
            get
            {
                return this.grade;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Grade must be higher than zero");
                }
                this.grade = value;
            }
        }

        public Student(string fname, string lname, double grade)
            : base(fname, lname)
        {
            this.Grade = grade;
        }
        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();
            studentInfo.AppendFormat("{0} Grade:{1}", base.ToString(), this.grade);
            return Convert.ToString(studentInfo);
        }
    }

