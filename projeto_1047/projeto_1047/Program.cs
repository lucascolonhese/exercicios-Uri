using System;

namespace projeto_1047{
    class program
    {
        static void Main(string[] args)
        {
            int H1, M1, H2, M2, horainicial, horafinal, duracaoH, duracaoM;

            string[] vet = Console.ReadLine().Split(' ');
            H1 = int.Parse(vet[0]);
            M1 = int.Parse(vet[1]);
            H2 = int.Parse(vet[2]);
            M2 = int.Parse(vet[3]);

            horainicial = H1 * 60 + M1;
            horafinal = H2 * 60 + M2;

            if (horainicial == horafinal)
            {
                Console.WriteLine("O JOGO DUROU 24 hora(s) e 0  MINUTO(S)");
            }
            else
            {
                if (horainicial < horafinal)
                {
                    duracaoH = (horafinal - horainicial) / 60;
                    duracaoM = (horafinal - horainicial) % 60;

                    Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");

                }
                else
                {
                    duracaoH = ((24 * 60 - horainicial) - horafinal) / 60;
                    duracaoM = ((24 * 60 - horainicial) - horafinal) % 60;

                    Console.WriteLine("O JOGO DUROU " + duracaoH + " HORA(S) E " + duracaoM + " MINUTO(S)");
                }

            }

            Console.ReadLine();
        }
    }
}
