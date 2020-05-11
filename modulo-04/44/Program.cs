using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor, vetor1; //declaração do "vetor-primario" e "vetor-respota"
            double c = 1;   //constante multiplicativa
            int n = 1;  //indice de looping

            vetor = new double[20]; //instanciação do "vetor-primario"
            vetor1 = new double[20];    //instanciação do "vetor-primario"

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
            n = 0;  //zerar o "n"
            Console.Write("Digite o valor da constante multiplicativa: ");
            c = int.Parse(Console.ReadLine());  //entrada da constante
            Console.WriteLine();

            while (n <= 19) //looping para multiplicação
            {
                vetor1[n] = vetor[n] * c;       //atribuição do "vetor-resposta"
                n++;
            }
            n = 0;  //zerar o "n"

            Console.WriteLine("O \"vetor original\" é o:");
            Console.WriteLine();

            while (n <= 19) //looping para exibição do "voter-primario"
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
            n = 0;  //zerar o "n"

            Console.WriteLine();
            Console.WriteLine("E o \"vetor resultado\" é o seguinte:");
            Console.WriteLine();

            while (n <= 19) //exibição do "vetor-resposta"
            {
                switch (n)
                {
                    case 0:
                        Console.Write("[{0}, ", vetor1[n]);
                        break;

                    case 19:
                        Console.WriteLine(" {0}]", vetor1[n]);
                        break;

                    default:
                        Console.Write(" {0}, ", vetor1[n]);
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
