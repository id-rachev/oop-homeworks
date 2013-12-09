using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class AudioDocument : MultimediaDocument
    {
        public int SampleRateHz
        {
            get;
            protected set;
        }

        public AudioDocument(string name, int sampleRateHz = 0)
            : base(name)
        {
            this.SampleRateHz = sampleRateHz;
        }
    }
}
