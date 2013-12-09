using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class VideoDocument : MultimediaDocument
    {
        public double FrameRate
        {
            get;
            protected set;
        }

        public VideoDocument(string name, double frameRate = 0)
            : base(name)
        {
            this.FrameRate = frameRate;
        }
    }
}
