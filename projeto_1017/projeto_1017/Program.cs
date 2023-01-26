using System;
using System.Globalization;

namespace projeto_1017 {
    class program    {
        static void Main(string[] args) {
            int velocidade, tempo;
            double consumo;

            velocidade = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            consumo = (double)(velocidade * tempo) / 12;

            Console.WriteLine(consumo.ToString("f3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

