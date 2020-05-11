using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
                //Receber 10 números e, exibi-los na ordem inversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;  //declaração do vetor que receberá os números
            int n = 1;  //valor que será usado para gerir o progresso do looping

            Console.WriteLine("Você irá digitar \"10\" números, eles devem ser inteiros, podem ser negativos"); //Informação ao usuário
            Console.WriteLine();

            numeros = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //instanciação do vetor

            while (n <= 10) //estrutura de repetição para recebimento dos números
            {
                switch (n)
                {
                    case 10:
                        Console.Write("Digite o último número: ");
                        numeros[(n - 1)] = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;

                    default:
                        Console.Write("Digite o {0}º número: ", n);
                        numeros[(n - 1)] = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }
                n++;
            }

            Console.WriteLine("Os números digitados, na ordem inversa:");
            Console.WriteLine();

            n = 9;

            while (n >= 0)  //repetição para exibição inversa
            {
                switch (n)
                {
                    case 9:
                        Console.Write("{0} -", numeros[n]);
                        break;

                    case 0:
                        Console.WriteLine(" {0}", numeros[n]);
                        break;

                    default:
                        Console.Write(" {0} -", numeros[n]);
                        break;
                }
                n--;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");

            Console.ReadKey();
        }
    }
}
