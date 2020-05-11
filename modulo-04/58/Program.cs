using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 2, n = 3, i = 0, i1 = i;
            string[,] matriz = new string[m, n];

            while (i < m)
            {
                while (i1 < n)
                {
                    Console.Write("Informe o nome da posição M {0}|{1}: ", (i + 1), (i1 + 1));
                    matriz[i, i1] = Console.ReadLine();
                    i1++;
                }
                i1 = 0;
                i++;
            }
            i = 0;
            Console.WriteLine();
            Console.WriteLine("A matriz inserida é a seguinte: ");
            Console.WriteLine();

            foreach (string elemento in matriz)
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
