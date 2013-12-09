using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Students;

namespace _04.Find_Students_Age
{
    // Write a LINQ query that finds the first name and last name
    // of all students with age between 18 and 24.

    class FindStudentsAge
    {
        static void Main()
        {
            StudentsAge firstStudent = new StudentsAge("Iliya", "Rachev", 32),            
            secondStudent = new StudentsAge("Petar", "Stoyanov", 21),
            thirdStudent = new StudentsAge("Todor", "Dimitrov", 24),
            fourthStudent = new StudentsAge("Simeon", "Bachev", 35);
            
            StudentsAge[] myStudents = new StudentsAge[]
            {
                firstStudent,
                secondStudent,
                thirdStudent,
                fourthStudent
            };

            Console.WriteLine("All students:");
            foreach (var student in myStudents)
            {
                Console.WriteLine("First name: {0}, last name: {1}, age: {2}.",
                    student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();

            var studentsAge18to24 =
                from student in myStudents
                where student.Age >= 18 && student.Age <= 24
                select student.FirstName + " " + student.LastName;

            Console.WriteLine("Finded students:");
            foreach (var student in studentsAge18to24)
            {
                Console.WriteLine(student);
            }
        }
    }
}
