using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a=");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("b=");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("c=");
        int c = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(a + "+" + b + "+" + c + "=" + (a + b + c));

    }
}
