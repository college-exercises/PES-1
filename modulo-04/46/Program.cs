using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes; //vetor de nomes
            int[] idades;   //vetor de idades
            int n = 0;  //indice de looping

            nomes = new string[100];    //instanciação de votor
            idades = new int[100];  //instanciação de votor

            while (n < 100) //looping para entrada de dados
            {
                if (n == 99)    //decisão para texto personalizado
                {
                    Console.Write("Digite o último nome: ");
                    nomes[n] = Console.ReadLine();  //entrada de nome
                    Console.Write("Digite a idade: ");
                    idades[n] = int.Parse(Console.ReadLine());  //entrada de idade
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Digite o {0}º nome: ", (n + 1));
                    nomes[n] = Console.ReadLine();  //entrada de nome
                    Console.Write("Digite a idade: ");
                    idades[n] = int.Parse(Console.ReadLine());  //entrada de idade
                    Console.WriteLine();
                }
                n++;
            }

            n = 0;  //zerar "n"
            
            while (n < 100) //looping para exibição dos nomes e idades
            {
                Console.Write("{0} - {1}", nomes[n], idades[n]);
                Console.WriteLine();
                n++;
            }

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
