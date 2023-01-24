using System;
using System.Globalization;

namespace projeto_1008
{
    class program
    {
        static void Main(string[] args)
        {
            int numero, horas;
            double valor, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valor * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY =  U$ " + salario.ToString("f2", CultureInfo.InvariantCulture));




        }
    }
}
Console.ReadLine();
