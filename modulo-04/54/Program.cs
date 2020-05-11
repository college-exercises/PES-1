using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, n = 20, aI = int.MinValue;
            string aS = string.Empty;
            char aC = char.MinValue;


            int[] idades;
            string[] nomes, ordNome, ordSexo, ordIdade;
            char[] sexos, nomesC;

            idades = new int[n];
            nomes = new string[n];
            sexos = new char[n];
            nomesC = new char[n];
            ordNome = new string[n];
            ordSexo = new string[n];
            ordIdade = new string[n];

            for (int z = 0; z < n; z++)
            {
                Console.Write("Informe o nome: ");
                nomes[z] = Console.ReadLine();
                nomes[z] = nomes[z].ToUpper();
                nomesC[z] = nomes[z][0];
                do
                {
                    Console.Write("Informe o sexo, use \"F\" ou \"M\": ");
                    sexos[z] = char.Parse(Console.ReadLine());
                    sexos[z] = Char.ToUpper(sexos[z]);
                } while (sexos[z] != 'F' && sexos[z] != 'M');
                do
                {
                    Console.Write("Informe a idade: ");
                    idades[z] = int.Parse(Console.ReadLine());
                } while (idades[z] < 0);
                Console.WriteLine();
            }

            //ordenar por sexo (crescente)
            while (i < n)
            {
                if (i == (n - 1))
                {
                    break;
                }
                else
                {
                    if (sexos[i] > sexos[(i + 1)])
                    {
                        aC = nomesC[i];
                        nomesC[i] = nomesC[(i + 1)];
                        nomesC[(i + 1)] = aC;
                        aC = sexos[i];
                        sexos[i] = sexos[(i + 1)];
                        sexos[(i + 1)] = aC;
                        aS = nomes[i];
                        nomes[i] = nomes[(i + 1)];
                        nomes[(i + 1)] = aS;
                        aI = idades[i];
                        idades[i] = idades[(i + 1)];
                        idades[(i + 1)] = aI;
                    }
                }
                i++;
            }
            i = 0;
            for (int z = 0; z < n; z++)
            {
                ordSexo[z] = nomes[z] + " " + sexos[z] + " " + idades[z];
            }
            //fim da ordenação por sexo

            //ordenar por idade (decrescente)
            while (i < n)
            {
                if (i == (n - 1))
                {
                    break;
                }
                else
                {
                    if (idades[i] < idades[(i + 1)])
                    {
                        aC = nomesC[i];
                        nomesC[i] = nomesC[(i + 1)];
                        nomesC[(i + 1)] = aC;
                        aI = idades[i];
                        idades[i] = idades[(i + 1)];
                        idades[(i + 1)] = aI;
                        aC = sexos[i];
                        sexos[i] = sexos[(i + 1)];
                        sexos[(i + 1)] = aC;
                        aS = nomes[i];
                        nomes[i] = nomes[(i + 1)];
                        nomes[(i + 1)] = aS;
                    }
                }
                i++;
            }
            i = 0;
            for (int z = 0; z < n; z++)
            {
                ordIdade[z] = nomes[z] + " " + sexos[z] + " " + idades[z];
            }
            //fim da ordenação por idade

            //ordenar por Nome (crescente)
            while (i < n)
            {
                if (i == (n - 1))
                {
                    break;
                }
                else
                {
                    if (nomesC[i] > nomesC[(i + 1)])
                    {
                        aC = nomesC[i];
                        nomesC[i] = nomesC[(i + 1)];
                        nomesC[(i + 1)] = aC;
                        aC = sexos[i];
                        sexos[i] = sexos[(i + 1)];
                        sexos[(i + 1)] = aC;
                        aS = nomes[i];
                        nomes[i] = nomes[(i + 1)];
                        nomes[(i + 1)] = aS;
                        aI = idades[i];
                        idades[i] = idades[(i + 1)];
                        idades[(i + 1)] = aI;
                    }
                }
                i++;
            }
            i = 0;
            for (int z = 0; z < n; z++)
            {
                ordNome[z] = nomes[z] + " " + sexos[z] + " " + idades[z];
            }
            //fim da ordenação por nome

            //exibições
            Console.WriteLine("Ordenado por Sexo (Crescente):");
            foreach (string elemento in ordSexo)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();

            Console.WriteLine("Ordenado por Idade (Decrescente):");
            foreach (string elemento in ordIdade)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();

            Console.WriteLine("Ordenado por Nome (Crescente):");
            foreach (string elemento in ordNome)
            {
                Console.WriteLine(elemento);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
