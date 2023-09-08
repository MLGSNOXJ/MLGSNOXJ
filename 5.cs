using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a=");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b=");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double c = a / b;

        Console.WriteLine(a.ToString("F3") + "/" + b.ToString("F3") + "=" + c.ToString("F3"));
    }
}
