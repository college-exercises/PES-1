using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
                //Entrar com 2 valores, o segundo maior que o primeiro, se não, pedir o segundo novamente
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2;

            Console.WriteLine("Digite o primeiro valor");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor. Ele deve maior que o primeiro");
            v2 = double.Parse(Console.ReadLine());

            while (v2<=v1)
            {
                Console.WriteLine("O segundo valor não superou o primeiro.");
                Console.WriteLine("Digite o segundo valor, maior que o primeiro dessa vez");
                v2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Parabéns! Pressione qualquer tecla para fechar o programa.");
            }

            Console.ReadKey();
        }
    }
}
