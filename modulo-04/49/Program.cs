using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes; //vetor de nomes
            int[] idades;   //vetor de idades
            string[] sexos;   //vetor de sexos
            int n = 0, q = 0;  //indice de looping, quantidade de pessoas listadas
            double qd, pl;  //quantidade de pessoas listadas em double, porcentagem dos listados

            nomes = new string[100];    //instanciação de vetor
            idades = new int[100];  //instanciação de vetor
            sexos = new string[100];   //instanciação de vetor

            while (n < 100) //looping para entrada de dados
            {
                if (n == 99)    //decisão para texto personalizado
                {
                    Console.Write("Digite o último nome: ");
                    nomes[n] = Console.ReadLine();  //entrada de nome
                    Console.Write("Digite a idade: ");
                    idades[n] = int.Parse(Console.ReadLine());  //entrada de idade

                    while (idades[n] <= 0)  //looping para restrição de idade
                    {
                        Console.WriteLine();
                        Console.WriteLine("A idade deve ser um número positivo!");
                        Console.Write("Digite a idade: ");
                        idades[n] = int.Parse(Console.ReadLine());  //entrada de idade
                    }

                    Console.Write("Digite o sexo. Use \"F\" ou \"M\": ");
                    sexos[n] = Console.ReadLine();  //entrada de sexo
                    while (sexos[n] != "m" && sexos[n] != "M" && sexos[n] != "f" && sexos[n] != "F")  //looping para restrição de resposta
                    {
                        Console.WriteLine();
                        Console.Write("Use \"F\" ou \"M\"! ");
                        Console.Write("Digite o sexo: ");
                        sexos[n] = Console.ReadLine();
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Digite o {0}º nome: ", (n + 1));
                    nomes[n] = Console.ReadLine();  //entrada de nome
                    Console.Write("Digite a idade: ");
                    idades[n] = int.Parse(Console.ReadLine());  //entrada de idade

                    while (idades[n] <= 0)  //looping para restrição de idade
                    {
                        Console.WriteLine();
                        Console.WriteLine("A idade deve ser um número positivo!");
                        Console.Write("Digite a idade: ");
                        idades[n] = int.Parse(Console.ReadLine());  //entrada de idade
                    }

                    Console.Write("Digite o sexo. Use \"F\" ou \"M\": ");
                    sexos[n] = Console.ReadLine();  //entrada de sexo
                    while (sexos[n] != "m" && sexos[n] != "M" && sexos[n] != "f" && sexos[n] != "F")  //looping para restrição de resposta
                    {
                        Console.WriteLine();
                        Console.Write("Use \"F\" ou \"M\"! ");
                        Console.Write("Digite o sexo: ");
                        sexos[n] = Console.ReadLine();
                    }
                    Console.WriteLine();
                }
                n++;
            }

            n = 0;  //zerar "n"

            while (n < 100) //looping para exibição dos nomes e idades
            {
                if (idades[n] > 20) //condição para restrição de idade
                {
                    Console.Write("{0} - {1} - {2}", nomes[n], idades[n], sexos[n]);
                    Console.WriteLine();
                    q++;
                }
                n++;
            }

            qd = q; //atribuindo o valor de "quantidade" para "quantidade double"

            if (q == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Não houve uma pessoa seuqer listada");
                Console.WriteLine("A porcentagem correspondente é exatamente 0.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Foram listadas {0} pessoas.", q);
                pl = (qd / n) * 100;
                Console.WriteLine("Isso corresponde a {0:f2}% do total", pl);
            }

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
