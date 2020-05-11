using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, h, a;    //base, altura e área

            Console.WriteLine("Digite a base");
            b = int.Parse(Console.ReadLine());  //entrada do valor de "b"
            Console.WriteLine("Digite a altura");
            h = int.Parse(Console.ReadLine());  //entrada do valor de "h"
            a = b * h;  //cálculo da área

            if (a < 100)    //constatação da área
            {
                Console.WriteLine("Terreno pequeno, {0} m²", a);
            }
            else
            {
                if (a > 100)
                {
                    Console.WriteLine("Terreno grande, {0} m²", a);
                }
                else
                {
                    Console.WriteLine("O terreno tem {0} m²", a);
                }
            }

            Console.ReadKey();
        }
    }
}
