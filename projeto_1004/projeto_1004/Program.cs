using System;

namespace projeto
{
    class program
    {
        static void Main(string[] args)
        {
            int a, b, prod;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            prod = a * b;

            Console.WriteLine("PROD = " + prod);

            Console.ReadLine();
        }
    }
}

