using System;
using System.Globalization;

namespace projeto_1009
{
    class Program
    {
        static void Main(String[] args)
        {
            string nome;
            double salario, venda, comissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            venda= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            comissao = salario + (venda * 0.15);


            Console.WriteLine("TOTAL = R$ " + comissao.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}


