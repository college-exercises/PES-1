using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, h, a;    //base, altura e área de um retângulo

            Console.WriteLine("Digite a base");
            b = int.Parse(Console.ReadLine());  //entrada do valor de "b"
            Console.WriteLine("Digite a altura");
            h = int.Parse(Console.ReadLine());  //entrada do valor de "h"
            a = b * h;  //cálculo da área

            if (a<100)  //constatação da área
            {
                Console.WriteLine("Terreno pequeno, {0} m²", a);
            }
            else
            {
                Console.WriteLine("{0} m²", a);
            }

            Console.ReadKey();
        }
    }
}
