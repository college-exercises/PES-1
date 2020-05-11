using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;   // valor "a" e valor "b"

            Console.WriteLine("Digite o Primeiro valor");
            a = int.Parse(Console.ReadLine());  //recebe o valor "a"
            Console.WriteLine("Digite o Segundo valor");
            b = int.Parse(Console.ReadLine());  //recebe o valor "b"

            if (a>b)    //condição para saber se "a" é maior que "b"
            {
                Console.WriteLine("O maior valor é o {0}", a);
            }
            else       //se não, então "b" é o maior
            {
                Console.WriteLine("O maior valor é o {0}", b);
            }

            Console.ReadKey();
        }
    }
}
