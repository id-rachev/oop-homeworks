using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    // We are given a school. In the school there are classes
    // of students. Each class has a set of teachers.
    // Each teacher teaches a set of disciplines. Students have
    // name and unique class number. Classes have unique text
    // identifier. Teachers have name. Disciplines have name,
    // number of lectures and number of exercises. Both teachers
    // and students are people. Students, classes, teachers and
    // disciplines could have optional comments (free text block).
    // Your task is to identify the classes (in terms of  OOP)
    // and their attributes and operations, encapsulate their fields,
    // define the class hierarchy and create a class diagram with Visual Studio.

    class SchoolMain
    {
        static void Main()
        {
            ClassAtSchool myClass = new ClassAtSchool("7A");

            Teacher firstTeacher = new Teacher("Ivan Ivanov");
            Teacher secondTeacher = new Teacher("Gospodin Gospodinov");
            Discipline firstDiscipline = new Discipline("OOP", 2, 2);
            Discipline secondDiscipline = new Discipline("JavaScript", 1, 1);
            Student firstStudent = new Student("Petar Goshev", 12);
            Student secondStudent = new Student("Georgi Petrov", 3);

            myClass.Teachers = new List<Teacher>() { firstTeacher };
            myClass.Teachers.Add(secondTeacher); // we could use Add method

            firstTeacher.DisciplinesSet =
                new List<Discipline>() { firstDiscipline, secondDiscipline };
            secondTeacher.DisciplinesSet =
                new List<Discipline>() { firstDiscipline };

            Console.WriteLine("Class name: {0}.", myClass.ClassID);
            foreach (var teacher in myClass.Teachers)
            {
                Console.Write("Teacher's name: {0}, disciplines: ", teacher.Name);
                foreach (var discipline in teacher.DisciplinesSet)
                {
                    Console.Write("{0} ", discipline.Name);
                }
                Console.WriteLine();
            }

            myClass.Students = new List<Student>() { firstStudent, secondStudent };

            foreach (var student in myClass.Students)
            {
                Console.WriteLine("Student's name: {0}, class number: {1}",
                    student.Name, student.ClassNumber);
            }

            firstDiscipline.Comments =
                new List<string>() { "OOP is hard for newbies like me. ;)" };
            firstStudent.Comments =
                new List<string>() { "Petar is very good student!" };

            Console.WriteLine("OOP comment: {0}.", firstDiscipline.Comments[0]);
            Console.WriteLine("Comment about student {0}: {1}",
                firstStudent.Name, firstStudent.Comments[0]);
        }
    }
}
