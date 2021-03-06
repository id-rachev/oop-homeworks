﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        private char[,] trailObjectBody = new char[,] { { '.' } };
        private int trailObjectLifetime;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjectLifetime)
            : base(topLeft, speed)
        {
            this.trailObjectLifetime = trailObjectLifetime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tail = new List<TrailObject>();

            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailObjectBody, this.trailObjectLifetime);
            tail.Add(trailObject);

            return tail;
        }
    }
}
