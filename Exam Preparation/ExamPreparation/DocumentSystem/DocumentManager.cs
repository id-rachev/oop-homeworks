using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class DocumentManager
    {
        List<IDocument> documents;

        public DocumentManager()
        {
            this.documents = new List<IDocument>();
        }

    }
}
