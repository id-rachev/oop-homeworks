using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class EncryptableBinaryDocument : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted
        {
            get;
            protected set;
        }

        public void Encrypt()
        {
            throw new NotImplementedException();
        }

        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        protected EncryptableBinaryDocument(string name, bool createEncrypted = false)
            : base(name)
        {
            this.IsEncrypted = false;
            if (createEncrypted)
            {
                this.Encrypt();
            }
        }

    }
}
