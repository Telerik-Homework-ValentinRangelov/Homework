using System;
namespace Range_Exceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T lowerLimit;
        private T upperLimit;
        public InvalidRangeException(string msg)
            : base(msg)
        {

        }
        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg,innerEx)
        {

        }
        public InvalidRangeException(string msg, T lowerLimit, T upperLimit)
            : this(msg)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
        }
        public InvalidRangeException(string msg,Exception innerEx, T lowerLimit, T upperLimit)
            : this(msg,innerEx)
        {
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
        }
        public T LowerLimit
        {
            get { return this.lowerLimit; }
            private set { this.lowerLimit = value; }
        }

        public T UpperLimit
        {
            get { return this.upperLimit; }
            private set { this.upperLimit = value; }
        }
    }
}
