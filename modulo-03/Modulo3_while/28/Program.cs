
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
            // Entrar com A, que será o valor da tabuada e B, que será o intervalo. Ambos positivos.
            //B deve ser maior que A,  e a tabuada será exibida em ordem decrescente, de B até A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, r;

            Console.WriteLine("Digite o primeiro valor. Ele deve ser inteiro e positivo.");
            a = int.Parse(Console.ReadLine());

            while (a<=0)
            {
                Console.WriteLine("O valor deve ser inteiro e positivo!");
                Console.WriteLine("Digite o valor.");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite o segundo valor. Ele deve ser inteiro e superior ao primeiro");
            b = int.Parse(Console.ReadLine());

            while (b<=a | b<=0)
            {
                Console.WriteLine("O segundo valor deve ser inteiro, positivo e superior ao primeiro!");
                Console.WriteLine("Digite o valor");
                b = int.Parse(Console.ReadLine());
            }

            i = b;

            while (i>=a)
            {
                r = a * i;
                Console.WriteLine("{0} x {1} = {2}", a, i, r);
                i--;
            }

            Console.WriteLine("Pressione qualquer tecla para fechar o programa");
            Console.ReadKey();
        }
    }
}
