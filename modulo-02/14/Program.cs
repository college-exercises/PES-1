using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, relacao;   //variáveis peso, altura e relação do IMC

            Console.WriteLine("Digite o seu peso");
            peso = double.Parse(Console.ReadLine());    //entrada do peso
            Console.WriteLine("Digite a sua altura");
            altura = double.Parse(Console.ReadLine());    //entrada da altura
            relacao = peso / Math.Pow(altura, 2);   //fórmula para o cálculo do IMC

            if (relacao < 20)   //constatação do resultado da relação
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else
            {
                if (relacao>=20 & relacao<25)
                {
                    Console.WriteLine("Você está com o peso ideal");
                }
                else
                {
                    Console.WriteLine("Você está acima do peso");
                }
            }

            Console.ReadKey();
        }
    }
}
