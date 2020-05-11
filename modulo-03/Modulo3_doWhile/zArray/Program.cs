using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
/* Fazer um programa para calcular a quantidade de jogos que temos que fazer,
 * para com certeza acertar o resultado da mega-sena.
 * Admitindo que faremos jogos de seis números por volante,
 * o programa deverá exibir quais seriam estes números em cada volante, ou seja,
 * exibir todos os resultados possíveis.
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("This is a line of text");
            Console.WriteLine("Everything written to Console.Write() or");
            Console.WriteLine("Console.WriteLine() will be written to a file");

            double cp, n, p, np, fatPXfatNP, fatN = 1, fatP = 1, fatNP = 1;
            sbyte[] array;

            n = 60;
            p = 6;
            np = (n - p);

            while (n >= 1)
            {
                fatN = fatN * n;
                n = n - 1;
            }

            while (p >= 1)
            {
                fatP = fatP * p;
                p = p - 1;
            }

            while (np >= 1)
            {
                fatNP = fatNP * np;
                np = np - 1;
            }
            fatPXfatNP = fatP * fatNP;
            cp = fatN / fatPXfatNP;

            //Aqui vem o bendito do vetor

            array = new sbyte[6] { 10, 10, 10, 10, 10, 10 };

            while (array[0] >= 1)
            {
                while (array[1] >= 1)
                {
                    while (array[1] == array[0])
                    {
                        if (array[1] < 1)
                        {
                            break;
                        }
                        else
                        {
                            array[1]--;

                        }
                    }

                    while (array[2] >= 1)
                    {
                        while (array[2] == array[1] || array[2] == array[0])
                        {
                            if (array[2] < 1)
                            {
                                break;
                            }
                            else
                            {
                                array[2]--;

                            }
                        }

                        while (array[3] >= 1)
                        {
                            while (array[3] == array[2] || array[3] == array[2] || array[3] == array[1] || array[3] == array[0])
                            {
                                if (array[3] < 1)
                                {
                                    break;
                                }
                                else
                                {
                                    array[3]--;

                                }
                            }

                            while (array[4] >= 1)
                            {
                                while (array[4] == array[3] || array[4] == array[2] || array[4] == array[1] || array[4] == array[0])
                                {
                                    if (array[4] < 1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        array[4]--;

                                    }

                                }

                                while (array[5] >= 1)
                                {
                                    while (array[5] == array[4] || array[5] == array[4] || array[5] == array[3] || array[5] == array[2] || array[5] == array[1] || array[5] == array[0])
                                    {
                                        if (array[5] < 1)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            array[5]--;

                                        }
                                    }

                                    if (array[0] != 0 && array[1] != 0 && array[2] != 0 && array[3] != 0 && array[4] != 0 && array[5] != 0)
                                    {

                                        Console.Write("{0}-", array[0]);
                                        Console.Write("{0}-", array[1]);
                                        Console.Write("{0}-", array[2]);
                                        Console.Write("{0}-", array[3]);
                                        Console.Write("{0}-", array[4]);
                                        Console.Write("{0}", array[5]);
                                        Console.WriteLine();

                                    }

                                    array[5]--;
                                }
                                array[5] = 10;
                                array[4]--;
                            }
                            array[5] = 10;
                            array[4] = 10;
                            array[3]--;
                        }
                        array[5] = 10;
                        array[4] = 10;
                        array[3] = 10;
                        array[2]--;
                    }
                    array[5] = 10;
                    array[4] = 10;
                    array[3] = 10;
                    array[2] = 10;
                    array[1]--;
                }
                array[5] = 10;
                array[4] = 10;
                array[3] = 10;
                array[2] = 10;
                array[1] = 10;
                array[0]--;
            }

            Console.WriteLine();
            Console.WriteLine("A quantidade de jogos possiveis é de {0}", cp);


            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}