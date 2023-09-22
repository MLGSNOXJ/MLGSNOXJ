a) using System;

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

d)using System;

class Program
{
    // Метод для вычисления суммы цифр числа
    static int GetSumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    // Метод для нахождения ближайшего предшествующего числа с заданной суммой цифр
    static int GetClosestNumber(int number, int targetSum)
    {
        int closestNumber = number - 1;

        while (GetSumOfDigits(closestNumber) != targetSum)
        {
            closestNumber--;
        }

        return closestNumber;
    }
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine()); // Заданние числа

        int sum = GetSumOfDigits(number); // Сумма цифр заданного числа

        int closestNumber = GetClosestNumber(number, sum); // Ближайшее предшествующее число

        Console.WriteLine(closestNumber);
    }

}







b) using System;

class HelloWorld
{
    static void Dig(int a, int b, int s, int c)
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
            if (s == c)
            {
                Console.Write(i + " ");
                s = 0;
            }
            else
            {
                s = 0;
                continue;
            }
        }
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int s = 0;

        Dig(a, b, s, c);
    }
}
c)using System;

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
            if (s % 2 != 0)
            {
                Console.Write(i + " ");
                s = 0;
            }
            else
            {
                s = 0;
                continue;
            }
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

d)using System;

class Program
{
    // Метод для вычисления суммы цифр числа
    static int DigS(int a)
    {
        int s = 0;

        while (a != 0)
        {
            s += a % 10;
            a /= 10;
        }

        return s;
    }

    // Метод для нахождения ближайшего предшествующего числа с заданной суммой цифр
    static int DigP(int a, int n)
    {
        int p = a - 1;

        while (DigS(p) != n)
        {
            p--;
        }

        return p;
    }
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine()); // Заданние числа

        int s = DigS(a); // Сумма цифр заданного числа

        int p = DigP(a, s); // Ближайшее предшествующее число

        Console.WriteLine(p);
    }

}

