using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

[Serializable]
public abstract class Function
{
    public abstract double Calculate(double x);
}

[Serializable]
public class Line : Function
{
    public double A { get; set; }
    public double B { get; set; }

    public override double Calculate(double x)
    {
        return A * x + B;
    }
}

[Serializable]
public class Kub : Function
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public override double Calculate(double x)
    {
        return A * x * x + B * x + C;
    }
}

[Serializable]
public class Hyperbola : Function
{
    public double A { get; set; }
    public double B { get; set; }

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
        // Сериализация массива функций в бинарный формат и сохранение в файле "functions.bin"
        Function[] functions = new Function[]
        {
            new Line { A = 2, B = 3 },
            new Kub { A = 1, B = 2, C = 3 },
            new Hyperbola { A = 1, B = 2 }
        };

        SerializeFunctions(functions);

        // Десериализация массива функций из файла "functions.bin"
        Function[] deserializedFunctions = DeserializeFunctions("functions.bin");

        // Вычисляем значения функций в заданной точке x
        double x = 5;
        List<double> results = new List<double>();
        foreach (var function in deserializedFunctions)
        {
            double result = function.Calculate(x);
            results.Add(result);
        }

        // Выводим результаты
        for (int i = 0; i < deserializedFunctions.Length; i++)
        {
            Console.WriteLine($"Function {i + 1}: {results[i]}");
        }

        Console.ReadLine();
    }

    static void SerializeFunctions(Function[] functions)
    {
        using (FileStream fs = new FileStream("functions.bin", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, functions);
        }
    }

    static Function[] DeserializeFunctions(string fileName)
    {
        Function[] deserializedFunctions;
        using (FileStream fs = new FileStream(fileName, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            deserializedFunctions = (Function[])formatter.Deserialize(fs);
        }
        return deserializedFunctions;
    }
}
