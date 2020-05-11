using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3, n = 4, i = 0, i1 = i, c = 0;
            int[,] matriz = new int[m, n], matrizB = new int[m, n];

            while (i < m)
            {
                while (i1 < n)
                {
                    Console.Write("Informe o valor de M {0}|{1}: ", (i + 1), (i1 + 1));
                    matriz[i, i1] = int.Parse(Console.ReadLine());
                    i1++;
                }
                i1 = 0;
                i++;
            }
            i = 0;

            Console.Write("Insira a constante multiplicativa: ");
            c = int.Parse(Console.ReadLine());

            for (int zi = 0; zi < m; zi++)
            {
                for (int zj = 0; zj < n; zj++)
                {
                    matrizB[zi, zj] = matriz[zi, zj] * c;
                }
            }

            Console.WriteLine();
            Console.WriteLine("A matriz inserida é a seguinte: ");
            Console.WriteLine();

            foreach (int elemento in matriz)
            {
                if (i == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    if (i % n == 0)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("{0} ", elemento);
                i++;
                if ((i) % n == 0)
                {
                    Console.WriteLine("|");
                }

            }

            Console.WriteLine();
            Console.WriteLine("A matriz resultante é a seguinte: ");
            Console.WriteLine();

            foreach (int elemento in matrizB)
            {
                if (i == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    if (i % n == 0)
                    {
                        Console.Write("|");
                    }
                }
                Console.Write("{0} ", elemento);
                i++;
                if ((i) % n == 0)
                {
                    Console.WriteLine("|");
                }

            }

            Console.ReadKey();
        }
    }
}
