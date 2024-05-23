using System;
using System.Collections.Generic;
using BusinessLogicLayer;

namespace PresentationLayer
{
    class Program
    {
        static void Main()
        {
            // Создаем массив функций
            Function[] functions = new Function[]
            {
                new Line(2, 3),
                new Kub(1, -1, 2),
                new Hyperbola(5, 1)
            };

            // Сортируем функции по коэффициенту a
            Array.Sort(functions);

            // Заданная точка
            double x = 2;

            // Вывод информации о значении функций в точке x
            foreach (var func in functions)
            {
                Console.WriteLine(func.Info());
                try
                {
                    Console.WriteLine($"Value at x = {x}: {func.Calculate(x)}\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}\n");
                }
            }
        }
    }
}
