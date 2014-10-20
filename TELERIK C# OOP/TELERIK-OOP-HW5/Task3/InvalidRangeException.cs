using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class InvalidRangeException<T> : ApplicationException
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private T start;
        private T end;

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }
        public T End
        {
            get { return end; }
            set { this.end = value; }
        }

        public InvalidRangeException(T start, T end)           
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message
        {
            get
            {
                string result = string.Format("Value is out of range {0} - {1}", this.Start, this.End);
                return result;
            }
        }
    }
}
