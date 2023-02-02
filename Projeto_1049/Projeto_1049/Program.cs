using System;

namespace projeto_1049
{
    class program
    {
        static void Main(string[] args)
        {
            string X, Y, Z;

            Console.Write("Digite se é vertebrado ou invertebrado: ");
            X = Console.ReadLine();
            if (X == "vertebrado" || X == "invertebrado")
            {
                if (X == "vertebrado")
                {
                    Console.Write("Digite se é ave ou mamifero: ");
                    Y = Console.ReadLine();
                    
                    
                    if (Y == "ave")
                    {
                        Console.Write("Digite se é carnivoro ou onivoro: ");
                        Z = Console.ReadLine();

                        if (Z == "carnivoro")
                        {
                            Console.WriteLine("Aguia");
                        }
                        else
                        {
                            if (Z == "onivoro")
                            {
                                Console.WriteLine("Pomba");
                            }
                        }
                    }
                    else
                    {
                        if (Y == "mamifero")
                        {
                            Console.Write("Digite se é carnivoro ou onivor: ");
                            Z = Console.ReadLine();

                            if (Z == "onivoro")
                            {
                                Console.WriteLine("Humano");
                            }
                            else
                            {
                                if (Z == "herbivoro")
                                {
                                    Console.WriteLine("Vaca");
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (X == "invertebrado")
                    {
                        Console.Write("Digite se é inseto ou anelidio: ");
                        Y = Console.ReadLine();

                        if (Y == "inseto")
                        {
                            Console.Write("Digite se é hematofago ou herbivoro: ");
                            Z = Console.ReadLine();

                            if (Z == "hematofago")
                            {
                                Console.WriteLine("Pulga");
                            }
                            else
                            {
                                if (Z == "herbivoro")
                                {
                                    Console.WriteLine("lagarta");
                                }
                            }
                        }
                        else
                        {
                            if (Y == "anelidio")
                            {
                                Console.Write("Digite se é hematofago ou onivoro: ");
                                Z = Console.ReadLine();

                                if (Z == "hematofago")
                                {
                                    Console.WriteLine("Sanguessuga");
                                }
                                else
                                {
                                    if (Z == "onivoro")
                                    {
                                        Console.WriteLine("minhoca");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else Console.WriteLine("Invalido, Sistema sendo encerrado.");

            Console.ReadLine();
        }
    }
}
