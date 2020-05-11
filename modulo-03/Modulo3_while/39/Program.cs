using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, n, ni;

            f = 1;
            Console.Write("Digite o número que deseja fatorar: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            ni = n;

            while (n<=0)
            {
                f = f * n;
                n--;
            }

            Console.WriteLine("O fatorial de {0} é igual a {1}.", ni, f);
            Console.ReadKey();
        }
    }
}
