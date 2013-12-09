using System;
using System.Collections.Generic;
using System.Linq;

public class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            if (this.MiddleName != null)
            {
                return this.FirstName + " " + this.MiddleName
                    + " " + this.LastName;
            }
            else
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
    public string SocialSNum { get; set; }
    public string PermAddress { get; set; }
    public string MobilePhone { get; set; }
    public string Email { get; set; }
    public byte? Course { get; set; }
    public Universities University { get; set; }
    public Faculties Faculty { get; set; }
    public Specialties Specialty { get; set; }

    public Student(string firstName, string lastName, string socialSnumber)
        : this(firstName, null, lastName, socialSnumber, null, null, null, null,
        Universities.Unspecified, Faculties.Unspecified, Specialties.Unspecified)
    {
    }

    public Student(string firstName, string middleName, string lastName,
        string socialSnumber, string permAddress, string mobilePhone,
        string eMail, byte? course, Universities university, Faculties faculty,
        Specialties specialty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SocialSNum = socialSnumber;
        this.PermAddress = permAddress;
        this.MobilePhone = mobilePhone;
        this.Email = eMail;
        this.Course = course;
        this.University = university;
        this.Faculty = faculty;
        this.Specialty = specialty;
    }

    public override bool Equals(object obj)
    {
        Student comparedObj = obj as Student;

        if (comparedObj == null)
        {
            return false;
        }
        if (!Object.Equals(this.FullName, comparedObj.FullName))
        {
            return false;
        }
        if (!Object.Equals(this.SocialSNum, comparedObj.SocialSNum))
        {
            return false;
        }
        return true;
    }

    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return Student.Equals(firstStudent, secondStudent);
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !(Student.Equals(firstStudent, secondStudent));
    }

    public override string ToString()
    {
        return String.Format("Student full name: {0}, SSN: {1},\n\raddress: {2}, " +
            "mobile: {3},\n\re-mail: {4}, course: {5},\n\rUniversity: {6}, Faculty: {7}, " +
            "Specialty: {8}.", FullName, SocialSNum, PermAddress, MobilePhone, Email,
            Course, University, Faculty, Specialty);
    }

    public override int GetHashCode()
    {
        return FullName.GetHashCode() ^ SocialSNum.GetHashCode();
    }

    public Student Clone()
    {
        Student originStud = this;
        Student cloneStud = new Student(this.FirstName, this.MiddleName, this.LastName,
        this.SocialSNum, this.PermAddress, this.MobilePhone, this.Email, this.Course,
        this.University, this.Faculty, this.Specialty);
        return cloneStud;
    }

    Object ICloneable.Clone()
    {
        return this.Clone();
    }

    public int CompareTo(Student otherStud)
    {
        if (this.FullName != otherStud.FullName)
        {
            return (this.FullName.CompareTo(otherStud.FullName));
        }
        if (this.SocialSNum != otherStud.SocialSNum)
        {
            return (this.SocialSNum.CompareTo(otherStud.SocialSNum));
        }
        return 0;
    }
}
