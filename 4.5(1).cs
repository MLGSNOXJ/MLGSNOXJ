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

using System;

class Program
{
    static int GetDigitsSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void PrintDigitsSumInRange(int i)
    {
            int sum = GetDigitsSum(i);
            Console.WriteLine($"Сумма цифр числа {i}: {sum}");
    }

    static void PrintNumbersWithDigitsSum(int i, int c)
    {
        
            int sum = GetDigitsSum(i);
            if (sum == c)
            {
                Console.WriteLine($"Число {i} имеет сумму цифр равную {c}");
            }
    }

    static void PrintOddDigitsSumNumbers(int i)
    {
            int sum = GetDigitsSum(i);
            if (sum % 2 != 0)
            {
                Console.WriteLine($"Число {i} имеет нечетную сумму цифр");
            }
        
    }

    static int GetClosestNumberWithSameDigitsSum(int number)
    {
        int targetSum = GetDigitsSum(number);
        int closestNumber = number - 1;
        int closestSum = GetDigitsSum(closestNumber);

        while (closestSum != targetSum)
        {
            closestNumber--;
            closestSum = GetDigitsSum(closestNumber);
        }

        return closestNumber;
    }

    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a) Сумма цифр чисел на отрезке [a, b]:");
        for (int i = a; i <= b; i++){

        
        PrintDigitsSumInRange(i);
        }
        Console.WriteLine("\nb) Числа на отрезке [a, b] с суммой цифр равной C:");
        for (int i = a; i <= b; i++){
        
        PrintNumbersWithDigitsSum(i, c);
        }
        Console.WriteLine("\nc) Числа на отрезке [a, b] с нечетной суммой цифр:");

        for (int i = a; i <= b; i++){
        PrintOddDigitsSumNumbers(i);
        }
        Console.WriteLine("\nd) Ближайшее предшествующее число к числу A с такой же суммой цифр:");
        int closestNumber = GetClosestNumberWithSameDigitsSum(A);
        Console.WriteLine($"Ближайшее предшествующее число к {A} с такой же суммой цифр: {closestNumber}");
    }
}



















using System;

class Program
{
    static int Sum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void SumInRange(int i)
    {
            int sum = Sum(i);
            Console.WriteLine($"Сумма цифр числа {i}: {sum}");
    }

    static void PrintNumbers(int i, int c)
    {
        
            int sum = Sum(i);
            if (sum == c)
            {
                Console.WriteLine($"Число {i} имеет сумму цифр равную {c}");
            }
    }

    static void PrintNNumbers(int i)
    {
            int sum = Sum(i);
            if (sum % 2 != 0)
            {
                Console.WriteLine($"Число {i} имеет нечетную сумму цифр");
            }
        
    }

    static int ClosestNumber(int number)
    {
        int targetSum = Sum(number);
        int closestNumber = number - 1;
        int closestSum = Sum(closestNumber);

        while (closestSum != targetSum)
        {
            closestNumber--;
            closestSum = Sum(closestNumber);
        }

        return closestNumber;
    }

    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a) Сумма цифр чисел на отрезке [a, b]:");
        for (int i = a; i <= b; i++){

        
        SumInRange(i);
        }
        Console.WriteLine("\nb) Числа на отрезке [a, b] с суммой цифр равной C:");
        for (int i = a; i <= b; i++){
        
        PrintNumbers(i, c);
        }
        Console.WriteLine("\nc) Числа на отрезке [a, b] с нечетной суммой цифр:");

        for (int i = a; i <= b; i++){
        PrintNNumbers(i);
        }
        Console.WriteLine("\nd) Ближайшее предшествующее число к числу A с такой же суммой цифр:");
        int closestNumber = ClosestNumber(A);
        Console.WriteLine($"Ближайшее предшествующее число к {A} с такой же суммой цифр: {closestNumber}");
    }
}
