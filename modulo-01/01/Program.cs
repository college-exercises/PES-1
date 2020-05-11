using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
                    //Área do triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a; //base, altura, área

            Console.Write("Digite a base ");
            b = double.Parse(Console.ReadLine()); //recebe a base
            Console.Write("Digite a altura ");
            h = double.Parse(Console.ReadLine()); //recebe a altura

            a = b * h; //fórmula para o cálculo da área

            Console.WriteLine("a area do retangulo é {0}", a); //exibe a área
            Console.ReadKey();
        }
    }
}
