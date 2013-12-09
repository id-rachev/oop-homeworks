using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[]
         {
             new Student("Nina","Nikolova",111),
             new Student("Ivana","Nikolova",112),
             new Student("Petra","Nikolova",113),
             new Student("Mina","Nikolova",114),
             new Student("Katq","Nikolova",115),

         };
        Teacher[] teachers = new Teacher[]
            {
                new Teacher("Ivan","Ivanov",new Discipline[]
                                                            {
                                                            new Discipline("OOP",4,5),
                                                            new Discipline("JS",7,8), 
                                                            }                          
               ),
                new Teacher("Petar","Petrov",new Discipline[]
                                                            {
                                                            new Discipline("OOP",2,10),
                                                            new Discipline("JS",3,10), 
                                                            }                          
               ),
            };
        SchoolClasses[] sk = new SchoolClasses[]
               {
                   new SchoolClasses(students,teachers,"ClassA"),
        };
        School mySchool = new School("Telerik", sk);
        Console.WriteLine(mySchool.ToString());
        //     mySchool.Classes[0].ClassTeachers[1].Comment ->add comment         
    }
}

