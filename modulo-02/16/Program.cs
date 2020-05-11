using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; //lados "a", "b" e "c" de um triângulo

            Console.WriteLine("Digite o valor do lado \"a\"");
            a = double.Parse(Console.ReadLine());   //entrada do lado "a"
            Console.WriteLine("Digite o valor do lado \"b\"");
            b = double.Parse(Console.ReadLine());   //entrada do lado "b"
            Console.WriteLine("Digite o valor do lado \"c\"");
            c = double.Parse(Console.ReadLine());   //entrada do lado "c"

            if (a > 0 && b > 0 && c > 0)  //condicional para verificar se os valores são superiores a 0
            {
                if (a + b > c || a + c > b || b + c > a)    //condicional para verificar se os valores dos lados formam um triângulo
                {
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2)) //condicional para verificar se os lados formam, ou não, um triângulo retângulo
                    {
                        Console.WriteLine("Sim, é possível gerar um triângulo retângulo com estes valores.");
                    }
                    else
                    {
                        Console.WriteLine("Não é possóvel gerar um triângulo retângulo com estes valores.");
                    }
                }
                else
                {
                    Console.WriteLine("Não é póssível formar um triângulo com estes valores!");
                }
            }
            else
            {
                Console.WriteLine("O valores não podem ser negativos ou nulos!");
            }

            Console.ReadKey();
        }
    }
}
