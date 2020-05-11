using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0, i1 = i;
            double m, a;
            double[] valores;

            do
            {
                Console.Write("Informe o valor de \"n\": ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 20);

            valores = new double[n];

            for (int z = 0; z < n; z++)
            {
                Console.Write("Digite o {0}º valor: ", (z+1));
                valores[z] = double.Parse(Console.ReadLine());
            }

            while (i1 < n) //ordena vetor
            {
                while (i < n)
                {
                    if (i == n - 1)
                    {
                        break;
                    }
                    else
                    {

                        if (valores[i] > valores[i + 1])
                        {
                            a = valores[i];
                            valores[i] = valores[i + 1];
                            valores[i + 1] = a;
                        }

                    }
                    i++;
                }
                i = 0;
                i1++;
            }

            if (n % 2 == 0) //é par
            {
                m = (valores[(n / 2) - 1] + valores[n / 2]) / 2;
            }
            else //é impar
            {
                m = valores[(n % 2 + n / 2) - 1];
            }

            Console.Write("A mediana é igual a {0}.", m);
            Console.ReadKey();
        }
    }
}
