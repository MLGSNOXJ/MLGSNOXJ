using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a=");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b=");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("c=");
        double c = Convert.ToDouble(Console.ReadLine());
        
       

        Console.WriteLine("(" + Math.Round(a, 2) + "+" + Math.Round(b, 2) + ")" + "+" + Math.Round(c, 2) + "="  + Math.Round(a, 2) + "+" + "(" + Math.Round(b, 2) + "+" + Math.Round(c, 2) + ")");
    }
}
