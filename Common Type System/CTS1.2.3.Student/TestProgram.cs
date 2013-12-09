using System;
using System.Collections.Generic;
using System.Linq;
class TestProgram
{
    static void Main()
    {
        Student firstStudent = new Student("Georgi", "Georgiev", "352-43-4532");
        Student secondStudent = new Student("Georgi", "Georgiev", "352-43-4532");

        Console.WriteLine(firstStudent);
        Console.WriteLine();
        Console.WriteLine(secondStudent);
        Console.WriteLine();
        Console.WriteLine(firstStudent.Equals(secondStudent));
        Console.WriteLine(firstStudent.GetHashCode());
        Console.WriteLine();

        Student thirdStudent = new Student("Darko", "Zarkov", "Darkov", "345-32-5678",
            "Sofia, 54 Ivan Asen II str.", "0889 634 101", "dzdarkov@mail.bg", 3,
            Universities.SofiaUniversity, Faculties.MathematicsAndInformatics, Specialties.SoftwareEngineering);

        Student cloneStudent = thirdStudent.Clone();

        thirdStudent.MobilePhone = "0882 652 232";
        Console.WriteLine(thirdStudent);
        Console.WriteLine();
        Console.WriteLine(cloneStudent);

        Console.WriteLine(firstStudent.CompareTo(thirdStudent));
        Console.WriteLine(thirdStudent.CompareTo(cloneStudent));
    }
}
