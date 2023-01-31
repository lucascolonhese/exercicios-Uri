using System;

namespace projeto_1044
{
    class program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            
            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else Console.WriteLine("Nao sao Multiplos");

            Console.ReadLine();
        }
    }
}
