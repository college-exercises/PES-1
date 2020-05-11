using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor; //declaração do vetor para armazenar os valores
            double c = 1;   //constante multiplicativa
            int n = 1;  //indice do looping

            vetor = new double[20]; //instanciação do vetor

            while (n <= 20) //looping para recebimento dos valores
            {
                switch (n)
                {
                    case 1:
                        Console.Write("Digite o {0}º valor: ", n);
                        vetor[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    case 20:
                        Console.Write("Digite o último valor: ");
                        vetor[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    default:
                        Console.Write("Digite o {0}º número: ", n);
                        vetor[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }
                n++;
            }
            n = 0;  //zerar o "n" para novo looping
            Console.Write("Digite o valor da constante: ");
            c = int.Parse(Console.ReadLine());  //entrada da constante multiplicativa
            Console.WriteLine();

            while (n <= 19) //looping de multiplicação
            {
                vetor[n] = vetor[n] * c;
                n++;
            }
            n = 0;  //zerar o "n" para exibição do "vetor-resposta"

            Console.WriteLine("O \"vetor resultado\" é o seguinte:");
            Console.WriteLine();

            while (n <= 19) //looping para exibição do "vetor-resposta"
            {
                switch (n)
                {
                    case 0:
                        Console.Write("[{0}, ", vetor[n]);
                        break;

                    case 19:
                        Console.WriteLine(" {0}]", vetor[n]);
                        break;

                    default:
                        Console.Write(" {0}, ", vetor[n]);
                        break;
                }
                n++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa");

            Console.ReadKey();
        }
    }
}