using System;

namespace projeto_1020{
    class program{
        static void Main(string[] args){
            int entrada, ano, mes, dias, sobra;

            entrada = int.Parse(Console.ReadLine());

            ano = entrada / 365;
            sobra = entrada % 365;

            mes = sobra / 30;
            dias = sobra % 30;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadLine();
        }
    }

}
