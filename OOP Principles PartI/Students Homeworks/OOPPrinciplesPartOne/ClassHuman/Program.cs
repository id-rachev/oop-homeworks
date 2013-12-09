using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>{
                new Student("Petar","Petrov",4.6),
                new Student("Pepi","Angelov",3.6),
                new Student("Katq","Koleva",5.6),
                new Student("Zina","Voina",4.7),
                new Student("Konan","Barberian",4.5),
                new Student("Terminator","Jeliazkov",5.5),
                new Student("Rambo","Kamenov",6),
                new Student("Boiko","borisov",3),
                new Student("Bilbo","Vasilev",4),
                new Student("Dildo","Dildov",3.5),
            };

            var studentQuery =
                from student in students
                orderby student.Grade
                select student;
            Console.WriteLine("Sorted by grade in ascending:");
            Console.WriteLine();
            foreach (var stu in studentQuery)
            {
                Console.WriteLine(stu.ToString());
            }
            List<Worker> workers = new List<Worker>{
                new Worker("Goran","Petrov",200,8),
                new Worker("Ivan","Angelov",450,8),
                new Worker("zlatka","Koleva",470,9),
                new Worker("Tina","Voina",400,12),
                new Worker("Bashta","Barberian",500,6),
                new Worker("Traqn","Jeliazkov",550,7),
                new Worker("Goch","Kamenov",560,8),
                new Worker("Boko","Borisov",600,12),
                new Worker("Frodo","Vasilev",700,17),
                new Worker("Zahari","Dildov",100,15),
            };
            var workerQuery =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine();
            Console.WriteLine("Sorted by money per hour in descending:");
            Console.WriteLine();
            foreach (var worker in workerQuery)
            {
                Console.WriteLine(worker.ToString());
            }
            List<Human> myList = new List<Human>();
            myList.AddRange(students);
            myList.AddRange(workers);
            Console.WriteLine();
            Console.WriteLine("Merge two lists and sort them by first name and last name");
            Console.WriteLine();

            var myMergeQuery =
                from list in myList
                orderby list.LastName
                orderby list.FirstName
                select list;
                    
            foreach (var item in myMergeQuery)
            {
                Console.WriteLine("{0},{1}-{2}", item.FirstName, item.LastName, item.GetType().Name);      
             //   Console.WriteLine("{0},{1}",item.ToString(),item.GetType().Name);
            }
           

            
        }
    }
}
