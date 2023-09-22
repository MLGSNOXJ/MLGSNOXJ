using System;
class HelloWorld
{
    static void Dig(int a)
    {
        if (a < 1)
            Console.Write("");
        else
        {
            Dig(a - 1);

            for (int i = 1; i <=a; i++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

       
    }

    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        Dig(a);
    }
}
