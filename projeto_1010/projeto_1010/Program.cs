using System;
using System.Globalization;

namespace projeto1010
{
    class program
    {
        static void Main(string[] args)
        {
            int cod1, peca1, cod2, peca2;
            double valor1, valor2, total;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            peca1= int.Parse(vet[1]);
            valor1= double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            cod2= int.Parse(vet[0]);
            peca2= int.Parse(vet[1]);
            valor2= double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = (valor1 * peca1) + (valor2 * peca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

