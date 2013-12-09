using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ClassAtSchool : ICommentable
    {
        public string ClassID { get; set; }
        public List<string> Comments { get; set; }

        private List<Teacher> teachers;
        private List<Student> students;

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        public ClassAtSchool(string classID)
            : this(classID, null, null)
        {
        }

        public ClassAtSchool(string classID,
            List<Teacher> teachers, List<Student> students)
        {
            this.ClassID = classID;
            this.Teachers = teachers;
            this.Students = students;
        }
    }
}
