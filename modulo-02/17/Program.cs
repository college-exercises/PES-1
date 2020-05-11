using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, h, r; //peso, altura, relação do IMC
            string s;   //sexo

            Console.WriteLine("Digite o seu sexo, use \"F\" ou \"M\"");
            s = Console.ReadLine(); //entrada do sexo

            if (s!="F" || s!="M" || s != "f" || s != "m")   //condicional para avaliar se o sexo é válido
            {
                Console.WriteLine("Há algo de errado na sua resposta, avalie novamente suas opções.");
            }
            else
            {
                Console.WriteLine("Digite o seu peso");
                p = double.Parse(Console.ReadLine());   //entrada do peso
                Console.WriteLine("Digite a sua altura");
                h = double.Parse(Console.ReadLine());   //entrada da altura
                r = p / Math.Pow(h, 2); //fórmula para o cálculo para a relação

                if (s == "M" || s == "m")   //condicional para analisar o IMC de acordo com o sexo
                {
                    if (r < 20)
                    {
                        Console.WriteLine("Você está abaixo do peso");
                    }
                    else
                    {
                        if (r >= 20 && r < 25)
                        {
                            Console.WriteLine("Você está com o peso ideal");
                        }
                        else
                        {
                            Console.WriteLine("Você está acima do peso");
                        }
                    }
                }
                else
                {
                    if (r < 19)
                    {
                        Console.WriteLine("Você está abaixo do peso");
                    }
                    else
                    {
                        if (r >= 19 && r < 24)
                        {
                            Console.WriteLine("Você está com o peso ideal");
                        }
                        else
                        {
                            Console.WriteLine("Você está acima do peso");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
