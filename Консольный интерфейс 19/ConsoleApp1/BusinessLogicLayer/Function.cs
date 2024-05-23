using System;

namespace BusinessLogicLayer
{
    public abstract class Function : IComparable<Function>
    {
        public abstract double A { get; }

        public abstract double Calculate(double x);
        public abstract string Info();

        public int CompareTo(Function other)
        {
            if (other == null)
                return 1;

            return this.A.CompareTo(other.A);
        }
    }
}
