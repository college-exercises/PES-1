using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
                //Recebe o valor em dólares, a cotação e, exibe em reais
{
    class Program
    {
        static void Main(string[] args)
        {
            double valDol, cot, valRel; //valor em dólar, cota do dólar, valor em reais

            Console.WriteLine("Digite o valor em Dólar");
            valDol = double.Parse(Console.ReadLine()); //recebe valor em dólar
            Console.WriteLine("Digite a cotação atual do dólar");
            cot = double.Parse(Console.ReadLine()); //recebe o valor da cota

            valRel = valDol * cot; //calculo para conversão de sólar em real

            Console.Write("${0} equivalem, atualmente, R${1}", valDol, valRel); //exibe o valor em real
            Console.ReadKey();
        }
    }
}
