using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IGatherer, IFighter
    {
        private int attackPoints = 150;
        private bool isStoneGathered = false;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                isStoneGathered = true;
                return true;
            }

            return false;
        }

        public int AttackPoints
        {
            get
            {
                if (isStoneGathered)
                {
                    attackPoints += 100;
                }
                return this.attackPoints; 
            }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
