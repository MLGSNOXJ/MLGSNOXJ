namespace BusinessLogicLayer
{
    public class Hyperbola : Function
    {
        private double a;
        private double b;

        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double A => a;

        public override double Calculate(double x)
        {
            if (x == 0)
            {
                throw new ArgumentException("x cannot be zero for hyperbola");
            }
            return a / x + b;
        }

        public override string Info()
        {
            return $"Hyperbola: y = {a}/x + {b}";
        }
    }
}
