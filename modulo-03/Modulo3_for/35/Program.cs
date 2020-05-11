using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n0, n1, ng, n;
            double FSn, FSnAnt, soma;

            FSnAnt = 2;
            n0 = 3;
            n1 = 2;
            soma = FSnAnt;
            ng = 2;
            FSn = 2;

            Console.WriteLine("O valor de \"n\" deve ser positivo e menor que 50.");

            do
            {
                Console.Write("Digite o valor de \"n\": ");
                Console.WriteLine();
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n >= 50);

            for (int i = ng; i <= n; i++)
            {
                FSn = (FSnAnt + n0) / Math.Pow(n1, 3);
                FSnAnt = FSn;
                n0 = n0 + 2;
                n1++;
                soma = soma + FSn;
                ng++;
            }

            Console.Write("A soma dos primeiros {0} termos da sequência resulta em, aproximadamente, {1:f2}.", n, soma);
            Console.ReadKey();
        }
    }
}
