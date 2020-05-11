using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42
                //Receber 10 números e, após isso, exibir o maior
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros;   //declaração do vetor
            double maior = double.MaxValue, menor = double.MinValue;    //atribuindo os valores de "crista e vale" para o maior e menor, respectivamente
            int n = 1;  //indice de loop

            numeros = new double[10];   //instanciação do vetor

            while (n <= 10) //loop para entrada dos valores, junto à decisão para atribuição de "maior" e "menor"
            {
                switch (n)
                {
                    case 1:
                        Console.Write("Digite o {0}º número: ", n);
                        numeros[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        maior = numeros[(n - 1)];
                        menor = numeros[(n - 1)];
                        break;

                    case 10:
                        Console.Write("Digite o último número: ");
                        numeros[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (numeros[(n - 1)] > maior)
                        {
                            maior = numeros[(n - 1)];
                        }
                        else
                        {
                            if (numeros[(n - 1)] < menor)
                            {
                                menor = numeros[(n - 1)];
                            }
                        }
                        break;

                    default:
                        Console.Write("Digite o {0}º número: ", n);
                        numeros[(n - 1)] = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (numeros[(n - 1)] > maior)
                        {
                            maior = numeros[(n - 1)];
                        }
                        else
                        {
                            if (numeros[(n - 1)] < menor)
                            {
                                menor = numeros[(n - 1)];
                            }
                        }
                        break;
                }
                n++;
            }

            if (maior == menor) //Decisão para o caso de não houverem "maior" e "menor"
            {
                Console.WriteLine("Os números são idênticos!");
            }
            else
            {
                Console.WriteLine("O maior número digitado foi o {0}, e o menor foi o {1}.", maior, menor);  //exibição
            }
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para fechar o progrma.");
            Console.ReadKey();
        }
    }
}
