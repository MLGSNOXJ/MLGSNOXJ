using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];

        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Введите элементы вектора Х:");

        int[] vectorX = new int[n];

        for (int i = 0; i < n; i++)
        {
            vectorX[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Исходный массив:");

        PrintArray(array);

        // Замена нечетных строк на вектор Х
        for (int i = 0; i < n; i += 2)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = vectorX[j];
            }
        }

        Console.WriteLine("Массив после замены:");

        PrintArray(array);
    }

    // Метод для печати двумерного массива
    static void PrintArray(int[,] array)
    {
        int n = array.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
