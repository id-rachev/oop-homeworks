using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InTheJungle
{
    public abstract class Creature : ISpeakable
    {
        public string Name { get; set;  }

        public Creature(string name)
        {
            this.Name = name;
        }

        public void Speak()
        {
        }
    }
}
