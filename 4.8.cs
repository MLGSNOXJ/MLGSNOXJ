using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        string str = Console.ReadLine();
        string[] split = str.Split(' ', '!', '?', '.', ',', ':', ';', '"', '\n', '\t');
        foreach(string s in split)
        {
            bool counts = s.Any(char.IsDigit);
            if (counts)
            {
                Console.WriteLine(s);
            }
        }
        

    }
}
