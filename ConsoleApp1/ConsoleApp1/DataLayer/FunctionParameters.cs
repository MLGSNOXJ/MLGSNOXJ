namespace DataLayer
{
    public class FunctionParameters
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public FunctionParameters(double a, double b, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
