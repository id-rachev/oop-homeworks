using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline : ICommentable
    {
        public string Name { get; set; }
        public ushort LecturesNum { get; set; }
        public ushort ExercisesNum { get; set; }
        public List<string> Comments { get; set; }

        public Discipline(string name)
            : this(name, 0, 0)
        {
        }

        public Discipline(string name, ushort lecturesNum, ushort exercisesNum)
        {
            this.Name = name;
            this.LecturesNum = lecturesNum;
            this.ExercisesNum = exercisesNum;
        }
    }
}
