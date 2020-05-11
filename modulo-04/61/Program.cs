using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, q = 0;
            double[,] matriz;
            string[] posicoes;
            double v = 0;

            Console.WriteLine("Os valores dos índices da matriz devem ser inteiros, positivos e estar entre 0 e 11. ");

            do
            {
                Console.Write("Informe o valor de \"m\": ");
                m = int.Parse(Console.ReadLine());
            } while (m <= 0 || m > 10);

            do
            {
                Console.Write("Informe o valor de \"n\": ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 10);

            matriz = new double[m, n];

            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int i1 = 0; i1 < n; i1++)
                {
                    Console.Write("Informe o valor de A {0}|{1}: ", (i+1), (i1+1));
                    matriz[i, i1] = double.Parse(Console.ReadLine());
                }
            }

            Console.Write("Informe o valor que deseja buscar: ");
            v = double.Parse(Console.ReadLine());
            Console.WriteLine();

            foreach (double elemento in matriz)
            {
                if (elemento == v)
                {
                    q++;
                }
            }

            posicoes = new string[q];

            int k = 0;

            for (int i = 0; i < m; i++)
            {
                for (int i1 = 0; i1 < n; i1++)
                {
                    if (matriz[i, i1] == v)
                    {
                        posicoes[k] = (i + 1) + "|" + (i1 + 1);
                        k++;
                    }
                }
            }

            if (q != 1)
            {
                Console.Write("As posiçoes em que \"{0}\" apareceu foram as seguintes: ", v);
                foreach (string elemento in posicoes)
                {
                    Console.Write(elemento+"; ");
                }
            }
            else
            {
                Console.Write("A posição em que \"{0}\" apareceu foi a {1}", v, posicoes[0]);
            }

            Console.ReadLine();
        }
    }
}
