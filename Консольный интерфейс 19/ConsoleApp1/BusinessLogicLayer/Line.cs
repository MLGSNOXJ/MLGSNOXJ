namespace BusinessLogicLayer
{
    public class Line : Function
    {
        private double a;
        private double b;

        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double A => a;

        public override double Calculate(double x)
        {
            return a * x + b;
        }

        public override string Info()
        {
            return $"Line: y = {a}x + {b}";
        }
    }
}

