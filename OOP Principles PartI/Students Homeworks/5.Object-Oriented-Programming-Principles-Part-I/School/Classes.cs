using System;
using System.Collections.Generic;

class Classes : IComments
{
    List<Students> students;
    List<Teachers> teachers;
    string classId;
    string comment;

    public string ClassId
    {
        get { return this.classId; }
        set { this.classId = value; }
    }

    public List<Students> Students
    {
        get { return this.students; }
        set
        {
            if (value.Count <= 0)
            {
                throw new ArgumentException("Class must have at least one student!");
            }
            else
            {
                this.students = value;
            }
        }
    }

    public List<Teachers> Teachers
    {
        get { return this.teachers; }
        set
        {
            if (value.Count <= 0)
            {
                throw new ArgumentException("Class must have at least one teacher!");
            }
            else
            {
                this.teachers = value;
            }
        }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Classes(string classId, List<Students> students, List<Teachers> teachers)
        : this(classId, students, teachers, null)
    {
    }

    public Classes(string classId, List<Students> students, List<Teachers> teachers, string comment)
    {
        this.classId = classId;
        this.Students = new List<Students>(students);
        this.Teachers = new List<Teachers>(teachers);
        this.Comment = comment;
    }

    public void AddComment(string comment)
    {
        this.Comment = comment;
    }
    public string ShowComment()
    {
        return this.Comment;
    }
}
    