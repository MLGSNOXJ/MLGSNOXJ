using System;

class Program
{
    static int НОД(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        else if (a > b)
        {
            return НОД(a - b, b);
        }
        else
        {
            return НОД(a, b - a);
        }
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int NOD = НОД(a, b);
        Console.WriteLine(NOD);
    }
}
