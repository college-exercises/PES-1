using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
                //Áreado quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double l, a; //lado, área

            Console.Write("Digite o lado do quadrado ");
            l = double.Parse(Console.ReadLine()); //recebe o lado

            a = Math.Pow(l, 2); //fórmula para cálculo da área

            Console.WriteLine("A area do quadrado é {0}", a); //exibe a área
            Console.ReadKey();
        }
    }
}
