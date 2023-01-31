using System;
using System.Data;

namespace projeto_1035
{
    class program
    {
        static void Main(String[] args)
        {
            int A, B, C, D, resultado;
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            resultado = A % 2;

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && resultado == 0)
            {
                Console.WriteLine("Valores aceitos");
            }

            else Console.WriteLine("Valores não aceitos");


            Console.ReadLine();

        }
    }
}
