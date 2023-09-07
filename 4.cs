using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a=");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b=");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double c = a * b;

        Console.WriteLine(Math.Round(a, 1) + "*" + Math.Round(b, 1) + "=" + Math.Round(c, 1));
    }
}
