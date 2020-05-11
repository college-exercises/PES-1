using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor;
            int n, ng = 0;   //declaração de "n"-> definido pelo usuário, índice de looping, posição
            string op = "S";    //declaração e atribuição da "opção" para "sim"

            while (op != "N" && op != "n")  //looping enquanto a "opção" for diferente de "não"
            {
                while (op == "S" || op == "s")  //looping enquanto "sim"
                {
                    Console.WriteLine("O valor de \"n\" deve ser inteiro e, estar no intervalo de \"1\" a \"20\".");
                    Console.Write("Digite o valor de n: ");
                    n = int.Parse(Console.ReadLine());  //entrada de "n"
                    Console.WriteLine();

                    while (n <= 0 || n > 20)    //looping para limite de valor aceito
                    {
                        Console.WriteLine("O valor de \"n\" deve estar entre \"0\" e \"21\".");
                        Console.Write("Digite o valor de n: ");
                        n = int.Parse(Console.ReadLine()); //entrada de "n"
                        Console.WriteLine();
                    }
                    vetor = new double[n];  //instanciação do vetor

                    while ((ng + 1) <= n) //looping para entrada de valores
                    {
                        if ((ng + 1) == n)      //decisão para exibição de mensagem personalizada
                        {
                            Console.Write("Digite o último valor: ");
                            vetor[ng] = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("Digite o {0}º valor: ", (ng + 1));
                            vetor[ng] = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }
                        ng++;
                    }

                    Console.Write("Digite a posição, do vetor, que deseja visualizar: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    while (p > n || p <= 0)     //looping para limite de valor aceito
                    {
                        Console.WriteLine("Posição inválida! Lembre que nosso vetor possue apenas {0} posições.", n);
                        Console.WriteLine();
                        Console.Write("Digite a posição, do vetor, que deseja visualizar: ");
                        p = int.Parse(Console.ReadLine());  //entrada da posição
                        Console.WriteLine();
                    }

                    Console.Write("O valor da {0}ª posição é o {1}", p, vetor[(p - 1)]);    //exibição da posição escolhida
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Deseja rodar o programa novamente? (Use \"S\" ou \"N\"): ");
                    op = Console.ReadLine();    //entrada da "opção"
                    Console.WriteLine();

                }

                while (op != "N" && op != "n" && op != "S" && op != "s")    //looping para resposta aceita
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                    Console.Write("Deseja rodar o programa novamente? (Use \"S\" ou \"N\"): ");
                    op = Console.ReadLine(); //entrada da "opção"
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
