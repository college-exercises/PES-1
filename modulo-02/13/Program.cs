using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // 3 valores, "a", "b" e "c"

            Console.WriteLine("Digite o primeiro valor");
            a = double.Parse(Console.ReadLine());   //entrada de "a"
            Console.WriteLine("Digite o segundo valor");
            b = double.Parse(Console.ReadLine());   //entrada de "b"
            Console.WriteLine("Digite o terceiro valor");
            c = double.Parse(Console.ReadLine());   //entrada de "c"

            if ( a > b )    //comparação entre os valores
            {
                if ( a > c )
                {
                    Console.WriteLine("O maior valor é o {0}", a);
                }
                else
                {
                    Console.WriteLine("O maior valor é o {0}", c);
                }
            }
            else
            {
                if (b>c)
                {
                    Console.WriteLine("O maior valor é o {0}", b);
                }
                else
                {
                    Console.WriteLine("O maior valor é o {0}", c);
                }
            }

            Console.ReadKey();
        }
    }
}
