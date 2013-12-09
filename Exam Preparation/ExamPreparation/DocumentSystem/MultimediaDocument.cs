using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class MultimediaDocument : BinaryDocument
    {
        public int LengthSeconds
        {
            get;
            protected set;
        }

        protected MultimediaDocument(string name, int lengthInSeconds = 0)
            : base(name)
        {
            this.LengthSeconds = lengthInSeconds;
        }
    }
}
