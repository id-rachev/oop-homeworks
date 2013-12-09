using System;
using System.Collections.Generic;

class Students : People, IComments
{
    int studentNum;
    string comment;

    public int StudentNum
    {
        get { return this.studentNum; }
        set
        {
            if (value < 0 || String.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentException("Invalid student number!");
            }
            else
            {
                this.studentNum = value;
            }
        }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Students(string fName, string lName, int studentNum)
        : base(fName, lName)
    {
        this.StudentNum = studentNum;
    }

    public Students(string fName, string lName, int studentNum, string comment)
        : base(fName, lName)
    {
        this.StudentNum = studentNum;
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
