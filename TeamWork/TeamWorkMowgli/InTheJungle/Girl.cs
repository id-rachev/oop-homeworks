using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InTheJungle
{
    public class Girl : Human
    {
        public Girl(string name)
            : base(name)
        {
        }

        public void Speak()
        {
            System.Console.WriteLine("I'm a girl from the Jungle");
        }
    }
}
