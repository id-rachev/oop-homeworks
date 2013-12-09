using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if ((value.Length < 2) || (value.Length > 20))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if ((value.Length < 2) || (value.Length > 20))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
