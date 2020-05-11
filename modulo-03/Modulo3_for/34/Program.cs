﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercício 34";

            double An, AnAnt, nc, soma;
            int n;

            An = 0.5;
            AnAnt = An;
            soma = An;
            nc = 2;

            Console.WriteLine("A sequência é: 1/2; 2/3; 3/4; 4/5...");
            Console.WriteLine();
            do
            {
                Console.WriteLine("O \"n\" deve ser interio e estar entre 0 e 50.");
                Console.Write("Digite o valor de n: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 50);
            
            Console.WriteLine();

            for (double i = nc; i <= n; i++)
            {
                An = AnAnt * (Math.Pow(n, 2) / (Math.Pow(n, 2) - 1));
                AnAnt = An;
                soma = soma + An;
            }

            Console.Write("A soma dos {0} primeiros termos da sequência resulta em aproximadamente {1:f2}", n, soma);

            Console.ReadKey();
        }
    }
}
