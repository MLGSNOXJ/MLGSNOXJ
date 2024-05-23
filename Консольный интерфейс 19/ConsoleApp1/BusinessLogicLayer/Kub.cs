namespace BusinessLogicLayer
{
    public class Kub : Function
    {
        private double a;
        private double b;
        private double c;

        public Kub(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double A => a;

        public override double Calculate(double x)
        {
            return a * x * x + b * x + c;
        }

        public override string Info()
        {
            return $"Kub: y = {a}x^2 + {b}x + {c}";
        }
    }
}
