using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
                // Exibir a soma dos n termos da sequencia 2, 5, 10, 17, 26... Com n entre 0 e 100
{
    class Program
    {
        static void Main(string[] args)
        {
            int FSAnt, SSAnt, n, ni, FSn, soma;

            FSAnt = 2;
            SSAnt = 3;
            ni = 2;
            soma = FSAnt;

            Console.WriteLine("A sequência é: \"2, 5, 10, 17, 26...\"");
            Console.WriteLine();

            do
            {
                Console.WriteLine("O \"n\" deve ser um número inteiro, no intervalo de 1 a 100");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0 | n > 100);

            do
            {
                FSn = FSAnt + SSAnt;
                FSAnt = FSn;
                SSAnt = SSAnt + 2;
                soma = soma + FSn;
                ni++;
            }
            while (ni <= n);

            Console.WriteLine("A soma dos {0} primeiros termos da sequência é igual a {1}", n, soma);
            Console.ReadKey();
        }
    }
}
