using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, v0, t, vF, vFC; //aceleração, velocidade Inicial, tempo, velocidade Final e velocidade Final Convertida

            Console.WriteLine("Digite a aceleração, em m/s²");
            a = double.Parse(Console.ReadLine());   //entrada da aceleração
            Console.WriteLine("Digite a velocidade inicial, em m/s");
            v0 = double.Parse(Console.ReadLine());  //entrada da velocidade Inicial
            Console.WriteLine("Digite o tempo percorrido, em s");
            t = double.Parse(Console.ReadLine());   //entrada do tempo
            vF = v0 + a * t;    //calculo da velocidade Final
            vFC = vF * 3.6; //calculo para conversão da velocidade Final em Km/h

            if ( a < 0 || v0 < 0 || t < 0 ) //condicional para checar se os valores são, ou não, negativos
            {
                Console.WriteLine("Os valores não podem ser negativos! Atente-se a isto da próxima vez.");
            }
            else
            {
                if ( vF <= 40 ) //condicional(is) para classificação da velocidade
                {
                    Console.WriteLine("Velocidade final de {0} km/h", vFC);
                    Console.WriteLine("Veículo muito lento.");
                }
                else
                {
                    if ( vF > 40 && vF <= 60 )
                    {
                        Console.WriteLine("Velocidade final de {0} km/h", vFC);
                        Console.WriteLine("Velocidade permitida.");
                    }
                    else
                    {
                        if ( vF > 60 && vF <= 80 )
                        {
                            Console.WriteLine("Velocidade final de {0} km/h", vFC);
                            Console.WriteLine("Velocidade de Cruzeiro.");
                        }
                        else
                        {
                            if ( vF > 80 && vF <= 120 )
                            {
                                Console.WriteLine("Velocidade final de {0} km/h", vFC);
                                Console.WriteLine("Veículo rápido.");
                            }
                            else
                            {
                                Console.WriteLine("Velocidade final de {0} km/h", vFC);
                                Console.WriteLine("Veículo muito rápido.");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
