using System;
using System.Collections.Generic;
using System.Text;



    class Teacher:Person
    {
        public List<Discipline> DisciplineTeacher { get; private set; }
        public Teacher(string firstname, string secondname,Discipline[] discpilines) : base(firstname, secondname) 
        {
            this.DisciplineTeacher = new List<Discipline>(discpilines);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            foreach (var item in DisciplineTeacher)
            {
                sb.Append("\n"+item.ToString());
            }
            return Convert.ToString(sb);
        }
    }

