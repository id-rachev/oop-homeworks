using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    // Define abstract class Human with first name and last name.
    // Define new class Student which is derived from Human and has
    // new field – grade. Define class Worker derived from Human
    // with new property WeekSalary and WorkHoursPerDay and method
    // MoneyPerHour() that returns money earned by hour by the worker.
    // Define the proper constructors and properties for this hierarchy.
    // Initialize a list of 10 students and sort them by grade in ascending
    // order (use LINQ or OrderBy() extension method). Initialize a list
    // of 10 workers and sort them by money per hour in descending order.
    // Merge the lists and sort them by first name and last name.

    class HumansMain
    {
        static void Main()
        {
            List<Student> myStudents = new List<Student>()
            {
                new Student("Anatoli", "Stoyanov", 4),
                new Student("Petar", "Zdravkov", 3.5f),
                new Student("Kiril", "Chuchkov", 5),
                new Student("Ivan", "Pekarov", 6),
                new Student("Krum", "Kovachev", 3),
                new Student("Spas", "Peshev", 4),
                new Student("Marina", "Dragostinova", 5.5f),
                new Student("Georgi", "Stoyanov", 4.5f),
                new Student("Ivan", "Asenov", 5),
                new Student("Vasilka", "Buzeva", 6)
            };

            List<Worker> myWorkers = new List<Worker>()
            {
                new Worker("Evgeni", "Yankov", 240m, 8),
                new Worker("Zdravko", "Angelov", 280m, 8),
                new Worker("Ivan", "Petrov", 240m, 8),
                new Worker("Dragomir", "Kolachev", 180m, 6),
                new Worker("Petar", "Vasilev", 260m, 8),
                new Worker("Deyan", "Velkov", 140m, 4),
                new Worker("Mihail", "Cvetanov", 240m, 8),
                new Worker("Yana", "Aleksandrova", 320m, 8),
                new Worker("Kalina", "Andreeva", 280m, 8),
                new Worker("Nadejda", "Borisova", 240m, 8),
            };

            //sorting students
            var sortedStudsByGrade = myStudents.OrderBy(x => x.Grade);

            foreach (var student in sortedStudsByGrade)
            {
                Console.WriteLine("Student name: {0} {1}, grade: {2}",
                    student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();

            // sorting workers
            var sortedWorksByMoneyPerH =
                from worker in myWorkers
                orderby worker.MoneyPerHour() descending
                select worker;

            foreach (var worker in sortedWorksByMoneyPerH)
            {
                Console.WriteLine("Worker name: {0} {1}, money per hour: {2:C}",
                    worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }
            Console.WriteLine();

            // sorting humans
            List<Human> myHumans =
                new List<Human>(myStudents.Count + myWorkers.Count);
            myHumans.AddRange(myStudents);
            myHumans.AddRange(myWorkers);

            var sortedHumansByName =
                from human in myHumans
                orderby human.FirstName, human.LastName
                select human;

            foreach (var human in sortedHumansByName)
            {
                Console.WriteLine("Human name: {0} {1}",
                    human.FirstName, human.LastName);
            }
        }
    }
}
