using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ng, maior, menor, num;
            double soma, media, qp, qn, qz, pp, pn, pz;
            string fq;

            do
            {
                maior = int.MinValue;
                menor = int.MaxValue;
                soma = 0;
                qp = 0;
                qn = 0;
                qz = 0;
                ng = 1;

                Console.WriteLine("Insira a quantidade de números que você irá digitar, chamaremos de \"n\".");
                Console.WriteLine("O valor de \"n\" deve ser inteiro, positivo e menor que \"20\".");
                Console.WriteLine();

                do
                {
                    Console.Write("Digte o valor de \"n\": ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                while (n <= 0 || n >= 20);

                for (int i = ng; i <= n; i++;)
                {
                    Console.Write("Digite o {0}º número: ", ng);
                    num = int.Parse(Console.ReadLine());
                    if (maior < num)
                    {
                        maior = num;
                    }
                    else
                    {
                        if (menor > num)
                        {
                            menor = num;
                        }
                    }

                    soma = soma + num;

                    if (num > 0)
                    {
                        qp = qp + 1;
                    }
                    else
                    {
                        if (num == 0)
                        {
                            qz = qz + 1;
                        }
                        else
                        {
                            qn = qn + 1;
                        }
                    }
                }
                Console.WriteLine();

                media = soma / n;
                pp = (qp / n) * 100;
                pn = (qn / n) * 100;
                pz = (qz / n) * 100;

                Console.WriteLine("O maior número digitado foi o {0}.", maior);
                Console.WriteLine("O menor número foi o {0}.", menor);
                Console.WriteLine("A soma dos números digitados resulta em \"{0}\".", soma);
                Console.WriteLine("A média dos números digitados resulta em, aproximadamente, \"{0:f1}\".", media);
                Console.WriteLine("A porcentagem, aproximada, dos positivos e negativos é, repectivamente, {0:f1}% e {1:f1}%.", pp, pn);

                if (qz > 0)
                {
                    Console.WriteLine("E a porcentagem dos \"zeros\" digitados é, aproximadamente, {0}%.", pz);
                }
                else
                {
                    Console.WriteLine("Não houve digitação de \"0\"");
                }
                Console.WriteLine();

                do
                {
                    Console.Write("Você deseja rodar o programa novamente? (S/N): ");
                    fq = Console.ReadLine();
                } while (fq != "S" && fq != "N" && fq != "s" && fq != "n"); ;

        } while (fq == "s" || fq == "S");

            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para fechar o programa...");

            Console.ReadKey();
        }
    }
}


