using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
                //Área do triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a; //base, altura, área

            Console.Write("Digite a base do triangulo");
            b = double.Parse(Console.ReadLine()); //recebe a base
            Console.Write("Digite a altura do triangulo");
            h = double.Parse(Console.ReadLine()); //recebe a altura

            a = (b * h) / 2; //fórmula para calculo da área

            Console.WriteLine("A Area do triangulo é {0}", a); //exibe a área
            Console.ReadKey();
        }
    }
}
