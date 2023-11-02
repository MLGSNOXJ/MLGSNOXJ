using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile1 = "1.txt";
        string inputFile2 = "2.txt";
        string outputFile = "output.txt";

        using (FileStream fileIn1 = new FileStream(inputFile1, FileMode.Open))
        using (FileStream fileIn2 = new FileStream(inputFile2, FileMode.Open))
        using (StreamWriter fileOut = new StreamWriter(outputFile))
        {
            StreamReader reader1 = new StreamReader(fileIn1);
            StreamReader reader2 = new StreamReader(fileIn2);

            while (!reader1.EndOfStream && !reader2.EndOfStream)
            {
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();

                string[] numbers1 = line1.Split(' ');
                string[] numbers2 = line2.Split(' ');

                for (int i = 0; i < numbers1.Length; i++)
                {
                    int num1 = int.Parse(numbers1[i]);
                    int num2 = int.Parse(numbers2[i]);

                    int sum = num1 + num2;

                    fileOut.Write(sum + " "); // Запись символа в файл
                }

                fileOut.WriteLine(); // Добавление перехода на новую строку между записями
            }
        }

        Console.WriteLine("bimbimbambam");
    }
}
