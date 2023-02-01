using System;
using System.Globalization;

namespace projeto_1040
{
    class program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, media, mediafinal;

            string[] vet = Console.ReadLine().Split(' ');

            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno aprovado");
            }
            else
            {
                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno está de exame");
                    Console.Write("nota do exame: ");
                    float N5;
                    N5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    mediafinal = (N5 + media) / 2;

                    if (mediafinal >= 5.0)
                    {
                        Console.WriteLine("Aluno aprovado.");
                    }
                    else Console.WriteLine("Aluno reprovado.");
                }
                else Console.WriteLine("Media: " + media);
                Console.WriteLine("Aluno reprovado");

            }
            
            
            Console.ReadLine();

        }
    }
}
