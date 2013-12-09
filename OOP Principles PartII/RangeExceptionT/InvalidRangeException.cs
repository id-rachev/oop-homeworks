using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptionT
{
    public class InvalidRangeException<T> : ApplicationException
        where T : struct, IFormattable, IComparable, IComparable<T>, IConvertible, IEquatable<T>
    {
        private T start;
        private T end;

        public T Start
        {
            get
            {
                return this.start;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end, Exception innerException)
            : base(message, innerException)
        {
            this.start = start;
            this.end = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }
    }
}
