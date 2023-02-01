using System;
using System.Globalization;

namespace projeto_1041
{

    class program
    {
        static void Main(string[] args)
        {

            double X, Y;

            string[] vet = Console.ReadLine().Split(' ');

            X = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Ponto Origem");
            }
            if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            
            if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            

            Console.ReadLine();

        }
    }
}

