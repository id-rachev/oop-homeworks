using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Students;

namespace _05.Sorting_Students
{
    // Using the extension methods OrderBy() and ThenBy() with
    // lambda expressions sort the students by first name and
    // last name in descending order. Rewrite the same with LINQ.

    class SortingStudents
    {
        private static void PrintIteration(IEnumerable<Student> sortedStudents)
        {
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("First name: {0}, last name: {1}.", student.FirstName, student.LastName);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Student firstStudent = new Student("Iliya", "Rachev"),
            secondStudent = new Student("Petar", "Stoyanov"),
            thirdStudent = new Student("Petar", "Dimitrov"),
            fourthStudent = new Student("Simeon", "Bachev");

            Student[] myStudents = new Student[]
            {
                firstStudent,
                secondStudent,
                thirdStudent,
                fourthStudent
            };

            var lambdaSortedStudents =
                myStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            PrintIteration(lambdaSortedStudents);


            var linqSortedStudents =
                from student in myStudents
                orderby student.FirstName descending, student.LastName descending
                select student;

            PrintIteration(linqSortedStudents);
        }
    }
}
