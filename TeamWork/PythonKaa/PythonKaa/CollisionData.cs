﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGame
{
    public class CollisionData
    {
        public readonly MatrixCoords CollisionForceDirection;
        public readonly List<string> hitObjectsCollisionGroupStrings;

        public CollisionData(MatrixCoords CollisionForceDirection, 
            string objectCollisionGroupString)
        {
            this.CollisionForceDirection = CollisionForceDirection;
            this.hitObjectsCollisionGroupStrings = new List<string>();
            this.hitObjectsCollisionGroupStrings.Add(objectCollisionGroupString);
        }

        public CollisionData(MatrixCoords collisionForceDirection, List<string> hitObjectsCollisionGroupStrings)
        {
            this.CollisionForceDirection = collisionForceDirection;

            this.hitObjectsCollisionGroupStrings = new List<string>();

            foreach (var str in hitObjectsCollisionGroupStrings)
            {
                this.hitObjectsCollisionGroupStrings.Add(str);
            }
        }
    }
}
