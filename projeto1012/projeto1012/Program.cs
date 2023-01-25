using System;
using System.Globalization;

namespace projeto1012
{
    class program
    {
        static void Main(string[] args)
        {
            double A, B, C, area;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
           
            A = double.Parse(vet[0], (CultureInfo.InvariantCulture));
            B = double.Parse(vet[1], (CultureInfo.InvariantCulture));
            C = double.Parse(vet[2], (CultureInfo.InvariantCulture));

            area = (A * C) / 2;
            Console.WriteLine("TRIANGULO: " + area.ToString("f3", CultureInfo.InvariantCulture));

            area = 3.14159 * Math.Pow(C, 2);
            Console.WriteLine("CIRCULO: " + area.ToString("f3", CultureInfo.InvariantCulture));

            area = ((A + B) * C) / 2;
            Console.WriteLine("TRAPEZIO: " + area.ToString("f3", CultureInfo.InvariantCulture));

            area = Math.Pow(B, 2);
            Console.WriteLine("QUADRADO: " + area.ToString("f3", CultureInfo.InvariantCulture));

            area = A * B;
            Console.WriteLine("RETANGULO: " + area.ToString("f3", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}


