using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Humans
{
     class Human
    {
        string fName;
        string lName;

        public string FName
        {
            get { return this.fName; }
            private set { this.fName = value; }
        }
        public string LName
        {
            get { return this.lName; }
            private set { this.lName = value; }
        }

        protected Human(string fName, string lName)
        {
            if (String.IsNullOrWhiteSpace(fName) || fName.Length < 2)
            {
                throw new ArgumentException("First name cannot be null or empty.");
            }

            if (String.IsNullOrWhiteSpace(lName) || lName.Length < 2)
            {
                throw new ArgumentException("Last name cannot be null or empty.");
            }

            this.FName = fName;
            this.LName = lName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FName, this.LName);
        }
    }
}
