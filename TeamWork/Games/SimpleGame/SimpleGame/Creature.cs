using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleGame
{
    public class Creature : Tile
    {
        private int hits;

        public delegate void CreatureDeadHandler(Object sender);
        public event CreatureDeadHandler CreatureDeadEvent;

        public int Hits
        {
            get
            {
                return hits;
            }
            set
            {
                hits = value;
                if (hits <= 0)
                {
                    if (CreatureDeadEvent != null)
                    {
                        CreatureDeadEvent(this);
                    }
                }
            }
        }

        public bool Alive
        {
            get { return (Hits >= 0); }
        }

        public void Attack(Creature creature)
        {
            creature.Hits = 0;
        }
    }
}
