using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Humans
{
    class Program
    {
        static void Main()
        {
            //Initialize studens
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student("Ivan", "Ivanov", 5.21));
            studentsList.Add(new Student("Asen", "Asenov", 3.65));
            studentsList.Add(new Student("Boris", "Borisov", 4.12));
            studentsList.Add(new Student("Simeon", "Simeonv", 2.96));
            studentsList.Add(new Student("Petar", "Petrov", 4.99));
            studentsList.Add(new Student("Georgi", "Georgiev", 5.64));
            studentsList.Add(new Student("Svetoslav", "Cvetanov", 3.71));
            studentsList.Add(new Student("Yordan", "Yordanov", 4.52));
            studentsList.Add(new Student("Todor", "Todorov", 3.12));
            studentsList.Add(new Student("Rosen", "Rusinov", 5.16));

            //Sort by gread and print students
            var sortedListByGrade = studentsList.OrderBy(x => x.Grade);
            foreach (var s in sortedListByGrade)
            {
                Console.WriteLine("{0}, grade: {1}", s.ToString(), s.Grade);
            }
            Console.WriteLine(); Console.WriteLine();

            //Initialize worker
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker("Petar", "Cvetanov", 532.6, 6.5));
            workersList.Add(new Worker("Simeon", "Rusinov", 634, 9));
            workersList.Add(new Worker("Georgi", "Asenov", 4236, 15));
            workersList.Add(new Worker("Boris", "Todorov", 453, 6.25));
            workersList.Add(new Worker("Yordan", "Simeonv", 223, 4));
            workersList.Add(new Worker("Todor", "Yordanov", 153, 3.25));
            workersList.Add(new Worker("Svetoslav", "Georgiev", 365, 5));
            workersList.Add(new Worker("Asen", "Borisov", 634.5, 11.75));
            workersList.Add(new Worker("Rosen", "Petrov", 414, 8));

            //Sort by money per hour and print workers
            var sortedListByMoney = workersList.OrderBy(x => x.MoneyPerHour());
            Console.WriteLine("Worker \t\t |Week Salary |Work Hours Per Day |Money Per Hour");
            foreach (var w in sortedListByMoney)
            {
                Console.WriteLine("{0,-20} {1, 8} {2,10} \t{3, 8:F2}", w.ToString(), w.WeekSalary, w.WorkHoursPerDay, w.MoneyPerHour());
            }
            Console.WriteLine();            

            //merge workers and students, sort by name and print final list
            List<dynamic> mergedList = new List<dynamic>();
            foreach (var s in studentsList)
            {
                mergedList.Add(s);
            }

            foreach (var w in workersList)
            {
                mergedList.Add(w);
            }

            var sortedMergedList = 
                from h in mergedList
                orderby h.FName, h.LName
                select h;

            foreach (var item in sortedMergedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
