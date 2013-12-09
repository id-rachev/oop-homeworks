using System;
using System.Collections.Generic;

class School
{
    static void Main()
    {
        Disciplines disciplineMath = new Disciplines("Math", 15, 15);
        List<Disciplines> discipline1 = new List<Disciplines>();
        discipline1.Add(disciplineMath);
        Teachers teacher1 = new Teachers("Todor", "Todorov", discipline1);

        Disciplines disciplineBg = new Disciplines("Bulgarian Language", 10, 10);
        Disciplines disciplineLit = new Disciplines("Literature", 10, 10);
        List<Disciplines> discipline2 = new List<Disciplines>();
        discipline2.Add(disciplineBg);
        discipline2.Add(disciplineLit);
        Teachers teacher2 = new Teachers("Petar", "Popov", discipline2);

        Disciplines disciplineBio = new Disciplines("Biology", 5, 5);
        Disciplines disciplineChemistry = new Disciplines("Chemistry", 5, 5);
        List<Disciplines> discipline3 = new List<Disciplines>();
        discipline3.Add(disciplineBio);
        discipline3.Add(disciplineChemistry);
        Teachers teacher3 = new Teachers("Ivan", "Ivanov", discipline3);

        List<Disciplines> discipline4 = new List<Disciplines>();
        Disciplines disciplineAstronomy = new Disciplines("Astronomy", 5, 5);
        discipline4.Add(disciplineAstronomy);
        Teachers teacher4 = new Teachers("Nikola", "Nikolov", discipline4);


        Students student1 = new Students("Georgi", "Georgiev", 3);
        Students student2 = new Students("Ivo", "Ivanov", 4);
        Students student3 = new Students("Alexander", "Alexandrov", 1);
        Students student4 = new Students("Boris", "Borisov", 2);
        Students student5 = new Students("Simeon", "Simeonov", 5);

        List<Students> studentsOne = new List<Students>();
        List<Students> studentsTwo = new List<Students>();
        studentsOne.Add(student1);
        studentsOne.Add(student3);
        studentsOne.Add(student4);
        studentsTwo.Add(student2);
        studentsTwo.Add(student5);

        List<Teachers> teachersOne = new List<Teachers>();
        List<Teachers> teachersTwo = new List<Teachers>();
        teachersOne.Add(teacher1);
        teachersOne.Add(teacher2);
        teachersOne.Add(teacher3);
        teachersTwo.Add(teacher1);
        teachersTwo.Add(teacher2);
        teachersTwo.Add(teacher4);

        Classes classOne = new Classes("Firts A", studentsOne, teachersOne);
        Classes classTwo = new Classes("Firts A", studentsTwo, teachersTwo);

        Console.WriteLine("{0} class have {1} students:", classOne.ClassId, classOne.Students.Count);
        foreach (var s in classOne.Students)
        {
            Console.WriteLine("{0}, with number {1}", s.ToString(), s.StudentNum);
        }
        Console.WriteLine("The teachers fo this class are:");
        foreach (var t in classOne.Teachers)
        {
            Console.WriteLine("{0} with disciplines:", t.ToString());
            foreach (var d in t.Disciplines)
            {
                Console.WriteLine("\t {0} (lecture: {1} and exercises {2} hour per week),", d.DisciplineName, d.DisciplineLectures, d.DisciplineExercises);
            }
        }
        Console.WriteLine();

        Console.WriteLine("{0} class have {1} students:", classTwo.ClassId, classTwo.Students.Count);
        foreach (var s in classTwo.Students)
        {
            Console.WriteLine("{0}, with number {1}", s.ToString(), s.StudentNum);
        }
        Console.WriteLine("The teachers fo this class are:");
        foreach (var t in classTwo.Teachers)
        {
            Console.WriteLine("{0} with disciplines:", t.ToString());
            foreach (var d in t.Disciplines)
            {
                Console.WriteLine("\t {0} (lecture: {1} and exercises {2} hour per week),", d.DisciplineName, d.DisciplineLectures, d.DisciplineExercises);
            }
        }
    }
}