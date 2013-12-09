using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public interface IDocument
    {
        string Name
        {
            get;
        }

        string Content
        {
            set;
        }

        void LoadProperty(string key, string value);

        void SaveAllPropertes();



        string ToString();
    }
}
