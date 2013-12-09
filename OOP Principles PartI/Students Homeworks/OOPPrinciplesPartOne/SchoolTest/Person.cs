using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public abstract class Person:IComentable
    {
        string firstName;
        string secondName;

        public string Comment { get; set; }

        public string FirstName { get; private set; }
        public string SecondName { get; private set; }

        protected Person(string firstname, string secondname)
        {
            if (String.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentNullException("First Name cant be left empty");
            }
            if(String.IsNullOrWhiteSpace(secondname))
            {
                throw new ArgumentNullException("Second name cant be left empty");
            }
            this.firstName = firstname;
            this.secondName = secondname;
        }
        public override string ToString()
        {
            return this.firstName +" " + this.secondName;
        }
       
    }

