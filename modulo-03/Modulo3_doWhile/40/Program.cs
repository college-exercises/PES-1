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
                ostrm = new FileStream("./Saida.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível abrir \"Saida.txt\"!");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("A seguir estão todas as combinações possíveis.");
            Console.WriteLine();

            double cp, n, p, np, fatPXfatNP, fatN = 1, fatP = 1, fatNP = 1;
            sbyte[] array;

            n = 60;
            p = 6;
            np = (n - p);

            do
            {
                fatN = fatN * n;
                n = n - 1;
            }
            while (n >= 1);

            do
            {
                fatP = fatP * p;
                p = p - 1;
            }
            while (p >= 1);

            do
            {
                fatNP = fatNP * np;
                np = np - 1;
            }
            while (np >= 1);
            fatPXfatNP = fatP * fatNP;
            cp = fatN / fatPXfatNP;

            //Aqui vem o bendito do vetor

            array = new sbyte[6] { 60, 60, 60, 60, 60, 60 };
            do
            {
                do
                {
                    do
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
                    while (array[1] == array[0]);

                    do
                    {
                        do
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
                        while (array[2] == array[1] || array[2] == array[0]);

                        do
                        {
                            do
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
                            while (array[3] == array[2] || array[3] == array[2] || array[3] == array[1] || array[3] == array[0]);

                            do
                            {
                                do
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
                                while (array[4] == array[3] || array[4] == array[2] || array[4] == array[1] || array[4] == array[0]);

                                do
                                {
                                    do
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
                                    while (array[5] == array[4] || array[5] == array[4] || array[5] == array[3] || array[5] == array[2] || array[5] == array[1] || array[5] == array[0]);

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
                                while (array[5] >= 1);
                                array[5] = 60;
                                array[4]--;
                            }
                            while (array[4] >= 1);
                            array[5] = 60;
                            array[4] = 60;
                            array[3]--;
                        }
                        while (array[3] >= 1);
                        array[5] = 60;
                        array[4] = 60;
                        array[3] = 60;
                        array[2]--;
                    }
                    while (array[2] >= 1);
                    array[5] = 60;
                    array[4] = 60;
                    array[3] = 60;
                    array[2] = 60;
                    array[1]--;
                }
                while (array[1] >= 1);
                array[5] = 60;
                array[4] = 60;
                array[3] = 60;
                array[2] = 60;
                array[1] = 60;
                array[0]--;
            }
            while (array[0] >= 1);

            Console.WriteLine();
            Console.WriteLine("A quantidade de jogos possiveis é de {0}", cp);

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("O arquivo foi criado com êxito ^^");


            Console.ReadKey();
        }
    }
}