using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            bool sair = false;

            do
            {

                Console.Clear();
                Console.WriteLine(" Qual cálculo deseja fazer ?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Sair");

                Console.WriteLine("----------");
                Console.WriteLine("Selecione uma opção: ");

                short res;

                if (short.TryParse(Console.ReadLine(), out res))
                {
                    switch (res)
                    {
                        case 1: Soma(); break;
                        case 2: Substracao(); break;
                        case 3: Divisao(); break;
                        case 4: Multiplicacao(); break;
                        case 5: sair = true; break;
                        default:
                            Console.WriteLine("Opção invalida. Pressione Enter para continuar.");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção invalida. Pressione Enter para continuar.");
                    Console.ReadLine();
                }

            } while (!sair);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");

            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Segundo Valor: ");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    float resultado = v1 + v2;
                    Console.WriteLine($"O resultado da soma é {resultado}");
                }
                else
                {
                    Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
            }
            Console.ReadLine();
        }

        static void Substracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");

            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Segundo Valor: ");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    float resultado = v1 - v2;
                    Console.WriteLine($"O resultado da subtração é {resultado}");
                }
                else
                {
                    Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
            }
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");

            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Segundo Valor: ");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    float resultado = v1 / v2;
                    Console.WriteLine($"O resultado da divisão é {resultado}");
                }
                else
                {
                    Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
            }
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");

            if (float.TryParse(Console.ReadLine(), out float v1))
            {
                Console.WriteLine("Segundo Valor: ");
                if (float.TryParse(Console.ReadLine(), out float v2))
                {
                    float resultado = v1 * v2;
                    Console.WriteLine($"O resultado da multiplicação é {resultado}");
                }
                else
                {
                    Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
                }
            }
            else
            {
                Console.WriteLine("Valor invalido. Pressione Enter para continuar.");
            }
            Console.ReadLine();
        }
    }
}