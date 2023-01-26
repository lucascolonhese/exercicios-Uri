using System;
using System.Xml;

namespace projeto_1018{
    class program{
        static void Main(string[] args)
        {
            int N, resultado, sobra, nota;

            N = int.Parse(Console.ReadLine());
            sobra = N;
            Console.WriteLine(N);
            
            nota = 100;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 100,00");
            sobra = sobra % nota;

            nota = 50;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 50,00");
            sobra = sobra % nota;

            nota = 20;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 20,00");
            sobra = sobra % nota;

            nota = 10;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 10,00");
            sobra = sobra % nota;

            nota = 5;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 5,00");
            sobra = sobra % nota;


            nota = 2;
            resultado = sobra / nota;
            Console.WriteLine(resultado + " nota(s) de R$ 2,00");
            sobra = sobra  % nota;

            Console.WriteLine(sobra + " nota(s) de R$ 1,00");

            Console.ReadLine();

        }
    }
}