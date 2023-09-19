using System;

class HelloWorld
{
    static void Dig(int a, int b, int s)
    {
        for (int i = a; i <= b; i++)
        {
            int num = i;
            while (num > 0)
            {
                int dig = num % 10;
                s += dig;
                num /= 10;
            }

            Console.Write(s + " ");
            s = 0;
        }
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int s = 0;

        Dig(a, b, s);
    }
}
