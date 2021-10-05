using System;

class TESTE
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        if (n == 1)
            Console.WriteLine("Top 1");
        else if (n == 2 || n == 3)
            Console.WriteLine("Top 3");
        else if (n == 4 || n == 5)
            Console.WriteLine("Top 5");
        else if (n >= 6 && n <= 10)
            Console.WriteLine("Top 10");
        else if (n >= 11 && n <= 25)
            Console.WriteLine("Top 25");
        else if (n >= 26 && n <= 50)
            Console.WriteLine("Top 50");
        else if (n >= 51 && n <= 100)
            Console.WriteLine("Top 100");
    }

}