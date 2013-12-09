using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Discipline:IComentable
    {
        public string Name { get; private set;}
        public int NumberLectures { get; private set; }
        public int NumberExercise { get; private set; }
        public string Comment { get; set; }

        public Discipline(string name, int lect, int exercise)
        {
            if (String.IsNullOrWhiteSpace(name) || lect <= 0 || exercise <= 0)
            {
                throw new ArgumentException("Discipline must have name, and number of lectures and exsercises bigger than zero");
            }
            else
            {
                this.Name = name;
                this.NumberLectures = lect;
                this.NumberExercise = exercise;
            }
        }
        public override string ToString()
        {
            return String.Format("Lecture name :{0} :Lectures: {1} Excercises:{2}", this.Name, this.NumberLectures, this.NumberExercise);
        }
    }

