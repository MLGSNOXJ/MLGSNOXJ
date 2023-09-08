using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите двухзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int maxDig= 0;

        while (num > 0)
        {
            int dig = num % 10;
            if (dig > maxDig)
            {
                maxDig = dig;
            }
            num /= 10;
        }

        Console.Write("Наибольшая цифра: " + maxDig);
    }
}
