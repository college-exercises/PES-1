using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;  //opção
            double b, h, a, r, l; //base, altura, área, raio e lado

            Console.WriteLine("Escolha a operação desejada para calcular a área:");
            Console.WriteLine();
            Console.WriteLine("1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Retângulo");
            Console.WriteLine("4 - Círculo");
            Console.WriteLine("5 - Fim de processo");
            Console.WriteLine();
            op = Console.ReadLine();    //recebe a opção

            if (op=="1" || op=="T")
            {
                Console.WriteLine("Digite a base do triângulo");
                b = double.Parse(Console.ReadLine());   //recebe a base
                Console.WriteLine("Digite a altura do triângulo");
                h = double.Parse(Console.ReadLine());   //recebe a altura
                a = b * h / 2;  //calculo da área
                Console.WriteLine("A área do triângulo é igual a {0}", a);
            }
            else
            {
                if (op == "2" || op == "Q")
                {
                    Console.WriteLine("Digite o lado do quadrado");
                    l = double.Parse(Console.ReadLine());   //recebe o lado
                    a = Math.Pow(l, 2); //cálculo da área
                    Console.WriteLine("A área do quadrado é igual a {0}", a);
                }
                else
                {
                    if (op == "3" || op == "R")
                    {
                        Console.WriteLine("Digite a base do retângulo");
                        b = double.Parse(Console.ReadLine());   //recebe a base
                        Console.WriteLine("Digite a altura do retângulo");
                        h = double.Parse(Console.ReadLine());   //recebe a altura
                        a = b * h;  //cálculo da área
                        Console.WriteLine("A área do retângulo é igual a {0}", a);
                    }
                    else
                    {
                        if (op == "4" || op == "C")
                        {
                            Console.WriteLine("Digite o valor do raio");
                            r = double.Parse(Console.ReadLine());   //recebe o raio
                            a = Math.PI * Math.Pow(r, 2);   //cálculo da área
                            Console.WriteLine("A área do círculo é igual a {0}", a);
                        }
                        else
                        {
                            if (op == "5" || op == "F")
                            {
                                Console.WriteLine("Pressione qualquer tecla para fechar o programa");
                            }
                            else
                            {
                                Console.WriteLine("Há algo de errado aqui, revise suas opções");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
