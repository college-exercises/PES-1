using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;   //valor "a" e valor "b"

            Console.WriteLine("Digite o Primeiro valor");
            a = int.Parse(Console.ReadLine());  //entrada do valor "a"
            Console.WriteLine("Digite o Segundo valor");
            b = int.Parse(Console.ReadLine());  //entrada do valor "b"

            if (a < b) //comparação dos valores, e constatação do menor
            {
                Console.WriteLine("O menor valor é o {0}", a);
            }
            else
            {
                Console.WriteLine("O menor valor é o {0}", b);
            }

            Console.ReadKey();
        }
    }
}
