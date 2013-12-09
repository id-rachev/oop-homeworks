using System;
using System.Collections.Generic;

class Teachers : People, IComments
{
    List<Disciplines> disciplines;
    string comment;

    public List<Disciplines> Disciplines
    {
        get { return this.disciplines; }
        set
        {
            if (value.Count < 1)
            {
                throw new ArgumentException("Teacher must have at least one discipline!");
            }
            else
            {
                this.disciplines = value;
            }
        }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Teachers(string fName, string lName, List<Disciplines> disciplines)
        : base(fName, lName)
    {
        this.Disciplines = new List<Disciplines>(disciplines);
        comment = String.Empty;
    }

    public Teachers(string fName, string lName, List<Disciplines> disciplines, string comment)
        : base(fName, lName)
    {
        this.Disciplines = new List<Disciplines>(disciplines);
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