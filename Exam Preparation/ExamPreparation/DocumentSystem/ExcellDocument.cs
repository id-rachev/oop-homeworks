using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class ExcellDocument : OfficeDocument
    {
        public int NumberOfRows { get; protected set; }

        public int NumberOfColumns { get; protected set; }

        public ExcellDocument(string name, int numberOfRows = 0, int numberOfColumns = 0)
            : base(name)
        {
            this.NumberOfRows = numberOfRows;
            this.NumberOfColumns = numberOfColumns;
        }
    }
}
