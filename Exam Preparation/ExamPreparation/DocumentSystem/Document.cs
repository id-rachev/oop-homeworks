using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        private readonly string name;
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        protected Document(string name)
        {
            this.name = name;
        }

        public string Content
        {
            set { throw new NotImplementedException(); }
        }

        public void LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        public void SaveAllPropertes()
        {
            throw new NotImplementedException();
        }
    }
}
