using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

[Serializable]
public abstract class Function
{
    // Абстрактный метод, который должны реализовать производные классы для вычисления значения функции в заданной точке
    public abstract double Calculate(double x);
}

[Serializable]
public class Line : Function
{
    // Параметры прямой: коэффициенты A и B в уравнении y = Ax + B
    public double A { get; set; }
    public double B { get; set; }

    // Реализация метода Calculate для прямой, вычисляющая значение функции для заданного x
    public override double Calculate(double x)
    {
        return A * x + B;
    }
}

[Serializable]
public class Kub : Function
{
    // Параметры кубической функции: коэффициенты A, B и C в уравнении y = Ax^2 + Bx + C
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    // Реализация метода Calculate для кубической функции, вычисляющая значение функции для заданного x
    public override double Calculate(double x)
    {
        return A * x * x + B * x + C;
    }
}

[Serializable]
public class Hyperbola : Function
{
    // Параметры гиперболы: коэффициенты A и B в уравнении y = A/x + B
    public double A { get; set; }
    public double B { get; set; }

    // Реализация метода Calculate для гиперболы, вычисляющая значение функции для заданного x
    public override double Calculate(double x)
    {
        if (x == 0)
            throw new ArgumentException("Cannot divide by zero.");
        return B + A / x;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив функций, содержащий экземпляры различных классов функций
        Function[] functions = new Function[]
        {
            new Line { A = 2, B = 3 },
            new Kub { A = 1, B = 2, C = 3 },
            new Hyperbola { A = 1, B = 2 }
        };

        // Вычисляем значения функций в заданной точке x
        double x = 5;
        List<double> results = new List<double>();
        foreach (var function in functions)
        {
            double result = function.Calculate(x);
            results.Add(result);
        }

        // Выводим результаты
        for (int i = 0; i < functions.Length; i++)
        {
            Console.WriteLine($"Function {i + 1}: {results[i]}");
        }

        // Сериализация массива функций в бинарный формат и сохранение в файле "functions.bin"
        using (FileStream fs = new FileStream("functions.bin", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, functions);
        }

        Console.ReadLine();
    }
}
