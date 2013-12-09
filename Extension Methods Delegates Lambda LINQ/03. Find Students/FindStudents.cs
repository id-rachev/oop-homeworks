using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Students
{
    // Write a method that from a given array of students finds all students
    // whose first name is before its last name alphabetically.
    // Use LINQ query operators.

    class FindStudents
    {
        protected static IEnumerable<Student> FindComparedNameStudents(Student[] myStudents)
        {
            var findStudents =
                from student in myStudents
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            return findStudents;
        }

        static void Main()
        {
            Student firstStudent = new Student ("Iliya", "Rachev"),
            secondStudent = new Student ("Petar", "Stoyanov"),
            thirdStudent = new Student ("Todor", "Dimitrov"),
            fourthStudent = new Student ("Simeon", "Bachev");

            Student[] myStudents = new Student[]
            {
                firstStudent,
                secondStudent,
                thirdStudent,
                fourthStudent
            };

            Console.WriteLine("All students:");
            foreach (var student in myStudents)
            {
                Console.WriteLine("First name: {0}, last name: {1}.", student.FirstName, student.LastName);
            }
            Console.WriteLine();

            var findStudents = FindComparedNameStudents(myStudents);

            Console.WriteLine("Finded students:");
            foreach (var student in findStudents)
            {
                Console.WriteLine("First name: {0}, last name: {1}.", student.FirstName, student.LastName);

            }
        }
    }
}
