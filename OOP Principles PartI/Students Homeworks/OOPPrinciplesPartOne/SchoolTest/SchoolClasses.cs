using System;
using System.Collections.Generic;
using System.Text;


    class SchoolClasses:IComentable
    {
       public List<Student> ClassStudents { get; private set; }
       public List<Teacher> ClassTeachers { get; private set; }
       public string UniqueClassName { get; private set; }
       public string Comment { get; set; } 

       public SchoolClasses(Student[] student, Teacher[] teacher, string uniquename)
       {
           this.ClassStudents = new List<Student>(student);
           this.ClassTeachers = new List<Teacher>(teacher);
           this.UniqueClassName = uniquename;
       }
       public override string ToString()
       {
           StringBuilder classInfo = new StringBuilder();
           classInfo.AppendLine("Class name:"+ this.UniqueClassName);
           classInfo.AppendLine("Students:");
           foreach (var item in this.ClassStudents)
           {
               classInfo.AppendLine(item.ToString());
           }
           classInfo.AppendLine("Teachers:");
           foreach (var item in this.ClassTeachers)
           {
               classInfo.AppendLine(item.ToString());
           }
           return Convert.ToString(classInfo);
       }
    }

