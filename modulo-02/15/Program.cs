using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
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

            if ( a > 0 && b > 0 && c > 0 )  //condicional para verificar se os valores são superiores a 0
            {
                if (a + b > c || a + c > b || b + c > a)    //condicional para verificar se os valores dos lados formam um triângulo
                {
                    if (a == b) //verificar se há lados iguais'
                    {
                        if (b == c) //verificar se há lados iguais''
                        {
                            Console.WriteLine("O triângulo formado com estes valores é equilátero");
                        }
                        else   //apenas um 2 lados iguais
                        {
                            Console.WriteLine("O triângulo formado com estes valores é isóceles");
                        }
                    }
                    else
                    {
                        if (a == c) //verificar se há lados iguais' -- !apenas um 2 lados iguais
                        {
                            Console.WriteLine("O triângulo formado com estes valores é isóceles");
                        }
                        else
                        {
                            if (b == c) //verificar se há lados iguais''
                            {
                                Console.WriteLine("O triângulo formado com estes valores é isóceles");
                            }
                            else   //nenhum lado igual
                            {
                                Console.WriteLine("O triângulo formado com estes valores é escaleno");
                            }
                        }
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
