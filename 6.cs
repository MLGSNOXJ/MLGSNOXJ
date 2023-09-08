
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
        
       

        Console.WriteLine("(" + a.ToString("F2") + "+" + b.ToString("F2") + ")" + "+" + c.ToString("F2") + "="  + a.ToString("F2") + "+" + "(" + b.ToString("F2") + "+" + c.ToString("F2") + ")");
    }
}
