using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class BinaryDocument : Document
    {
        public int SizeBytes
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        protected BinaryDocument(string name, int sizeInBytes = 0)
            : base(name)
        {
            this.SizeBytes = sizeInBytes;
        }

        public void LoadProperty()
        {
            throw new NotImplementedException();
        }

        public void SaveAllPropertes()
        {
            throw new NotImplementedException();
        }
    }
}
