using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InTheJungle
{
    public class Boy : Human
    {
        public Boy(string name)
            : base(name)
        {
        }

        public void Speak()
        {
            System.Console.WriteLine("I'm a boy from the Jungle");
        }
    }
}
