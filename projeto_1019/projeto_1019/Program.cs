using System;

namespace projeto_1019{
    class program{
        static void Main(string[] args){

            int segundos, minutos, horas, entrada, sobra;

            entrada = int.Parse(Console.ReadLine());

            horas = entrada / 3600;
            sobra = entrada % 3600;

            minutos = sobra / 60;
            segundos = entrada % 60;

            Console.WriteLine(horas + " : " + minutos + " : " + segundos);

            Console.ReadLine();

        }
    }
}