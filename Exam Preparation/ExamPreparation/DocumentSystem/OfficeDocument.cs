using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class OfficeDocument : EncryptableBinaryDocument
    {
        public bool IsEncrypted
        {
            get { throw new NotImplementedException(); }
        }

        public string Version
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        protected OfficeDocument(string name, string version = "")
            : base(name)
        {
            this.Version = version;
        }
    }
}
