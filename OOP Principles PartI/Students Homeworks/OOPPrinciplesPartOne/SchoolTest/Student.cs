using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Student:Person
    {
        private int id;

        public int Id { get; private set; }

        public Student(string firstname, string secondname,int id)
            : base(firstname,secondname)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return String.Format("{0} ID: {1}", base.ToString(), this.id);
        }
        
    }

