using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, maior =0, n =1;
            double media, soma = 0;

            Console.WriteLine("Você irá digitar 10 números, eles devem ser inteiros e positivos");

            while (n<=10)
            {
                Console.Write("Digite o {0}º número: ", n);
                num = int.Parse(Console.ReadLine());

                while (num<=0)
                {
                    Console.WriteLine("O número deve ser inteiro e positivo!");
                    Console.WriteLine();
                    Console.Write("Digite o {0}º número: ", n);
                    num = int.Parse(Console.ReadLine());
                }

                if (num>maior)
                {
                    maior = num;
                }
                else
                {
                    maior = maior;
                }

                soma = soma + num;
                n++;
            }

            media = soma / 10;
            Console.WriteLine();
            Console.WriteLine("O maior número digitado foi o \"{0}\".", maior);
            Console.WriteLine("A soma de todos os números digitados resulta em {0}.", soma);
            Console.WriteLine("A média aritmética de todos os números digitados é igual a {0:f1}.", media);
            Console.ReadKey();
        }
    }
}
