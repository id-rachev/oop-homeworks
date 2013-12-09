using System;
using System.Collections.Generic;

class Disciplines : IComments
{
    string disciplineName;
    int disciplineLectures;
    int disciplineExercises;
    string comment;

    public string DisciplineName
    {
        get { return this.disciplineName; }
        set
        {
            if (value.Length <= 2 || String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalide discipline name!");
            }
            else
            {
                this.disciplineName = value;
            }
        }
    }
    public int DisciplineLectures
    {
        get { return this.disciplineLectures; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("There must have at least one lecture!");
            }
            else
            {
                this.disciplineLectures = value;
            }
        }
    }
    public int DisciplineExercises
    {
        get { return this.disciplineExercises; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("There must have at least one exercises!");
            }
            else
            {
                this.disciplineExercises = value;
            }
        }
    }
    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Disciplines(string disciplineName, int disciplineLectures, int disciplineExercises)
        : this(disciplineName, disciplineLectures, disciplineExercises, null)
    {
    }

    public Disciplines(string disciplineName, int disciplineLectures, int disciplineExercises, string comment)
    {
        this.DisciplineName = disciplineName;
        this.DisciplineLectures = disciplineLectures;
        this.DisciplineExercises = disciplineExercises;
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