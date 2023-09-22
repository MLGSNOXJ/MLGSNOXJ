class HelloWorld
{
    static void Dig(int a, int s)
    {
        for(int i = 1; i <= a; i++)
        {
            for(int j = i; j >= 1; j--)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int s = 0;

        Dig(a, s);
    }
}
