using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
                //Recebe temperatura em C°, e exibe em F°
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fa, Ce; //Graus em Fahrenheit e Celsius, respectivamente

            Console.Write("Escreva a temperatura em Celcius ");
            Ce = double.Parse(Console.ReadLine()); //Recebe C°

            Fa = ((Ce * 9) / 5) + 32; //Fórmula para conversão

            Console.WriteLine("A temperatura de {0} C° equicale a {1} F°", Ce, Fa); //Exibe a conversão

            Console.ReadKey();
        }
    }
}
