using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace curso{
    class program
    {
        static void Main(string[] args)
        {
            double area, n, x, y;
           

            n = 3.14159;
            x = double.Parse(Console.ReadLine());
            y = 2.00;

            area = n * (Math.Pow (x, y));

            Console.WriteLine(" A= " + area.ToString("f4"));


            Console.ReadLine();
        }

    }
}


