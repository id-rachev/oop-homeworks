using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class PDFDocument : EncryptableBinaryDocument
    {
        private bool isEncrypted;

        public bool IsEncrypted
        {
            get { return this.isEncrypted; }
        }

        public int NumberOfPages   { get;  protected set; }

        public PDFDocument(string name, int numberOfPages = 0)
            : base(name)
        {
            this.NumberOfPages = numberOfPages;
        }

    }
}
