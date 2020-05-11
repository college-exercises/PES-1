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

            do
            {
                Console.Write("Digite o número que deseja fatorar. O número deve ser inteiro e positivo: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            f = 1;
            ni = n;

            if (n==0)
            {
                Console.WriteLine("O fatorial de 0 é igual a 1.");
            }
            else
            {
                for (int i = n; i > 0; i--)
                {
                    f = f * n;
                    n--;
                }

                Console.WriteLine("O fatorial de {0} é igual a {1}.", ni, f);
            }

            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
