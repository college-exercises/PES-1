﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
                //Entrar com um valor. Aceitar somente valores positivos.
                //Após a digitação, exibir a tabuada do valor, no intervalo de um a dez.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=1, v, r;

            do
            {
                Console.WriteLine("Digite o valor. Ele deve ser um número inteiro e positivo.");
                v = int.Parse(Console.ReadLine());
            }
            while (v <= 0);

            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Tabuada do {0}", v);
            Console.WriteLine();

            for (n = 1; n <= 10; n++)
            {
                r = n * v;
                Console.WriteLine("{0} x {1} = {2}", v, n, r);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
