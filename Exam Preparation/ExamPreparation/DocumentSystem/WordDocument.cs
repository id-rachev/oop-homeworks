using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocument
    {
        public int NumberOfCharacters { get; protected set; }

        public WordDocument(string name, int numberOfCharacters = 0)
            : base(name)
        {

        }
    
        public void ChangeContent(string changeContent)
        {
            throw new NotImplementedException();
        }
    }
}
