using System;
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

            Console.WriteLine("Digite o valor. Ele deve ser um número inteiro e positivo.");
            v = int.Parse(Console.ReadLine());

            while (v <= 0)
            {
                Console.WriteLine("O valor deve ser positivo, ou seja, superior a 0.");
                Console.WriteLine("Digite o valor");
                v = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Tabuada do {0}", v);
            Console.WriteLine();

            while (n<=10)
            {
                r = n * v;
                Console.WriteLine("{0} x {1} = {2}", v, n, r);
                n++;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
