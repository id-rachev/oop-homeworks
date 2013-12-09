using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class TextDocument : Document, IEditable
    {
        public string Charset { get; protected set; }

        public TextDocument(string name, string charset = "")
            : base(name)
        {
            this.Charset = charset;
        }

        public void LoadProperty()
        {
            throw new NotImplementedException();
        }

        public void SaveAllPropertes()
        {
            throw new NotImplementedException();
        }

        public void ChangeContent(string changeContent)
        {
            throw new NotImplementedException();
        }
    }
}
