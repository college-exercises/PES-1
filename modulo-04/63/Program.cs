using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10,
                j = 4,
                qC = 0,
                m = 0,
                n = 0,
                c = 0;

            char r = '-';

            char[,] lugares = new char[i, j];

            string[] nomes = new string[(i*j)];

            bool lotado = false,
                 lugarLivre = true,
                 lugarValido = true;

            for (int a = 0; a < i; a++)
            {
                for (int b = 0; b < j; b++)
                {
                    lugares[a, b] = (r);
                }
            } //atribue '-' a todos os lugares

            for (int a = 0; a < lugares.Length; a++)
            {
                Console.Write("Informe o seu nome: ");
                nomes[a] = Console.ReadLine();

                do
                {
                    if (!lugarLivre)
                    {
                        Console.WriteLine("O lugar já está ocupado!");
                    } //o lugar escolhido anteriormente já está ocupado

                    {
                        do
                        {
                            if (!lugarValido)
                            {
                                Console.WriteLine("Fileira inválida!");
                            } //a fileira escolhida não existe

                            {
                                Console.WriteLine();
                                Console.Write("Informe a fileira que deseja: ");
                                n = int.Parse(Console.ReadLine());
                            } //recebe a fileira

                            {
                                if (n > j || n <= 0)
                                {
                                    lugarValido = false;
                                }
                                else
                                {
                                    lugarValido = true;
                                }
                            }  //valida a existência da fileira

                        } while (n > j || n <= 0); //recebe a fileira

                        do
                        {
                            if (!lugarValido)
                            {
                                Console.WriteLine("Cadeira inválida!");
                            } //a cadeira escolhida não existe

                            {
                                Console.Write("Informe a cadeira que deseja: ");
                                m = int.Parse(Console.ReadLine());
                            } //recebe a cadeira

                            {
                                if (m > i || m <= 0)
                                {
                                    lugarValido = false;
                                }
                                else
                                {
                                    lugarValido = true;
                                }
                            } //valida a existência da cadeira

                        } while (m > i || m <= 0); //recebe a cadeira
                    } //recebe o assento

                    {
                        if (lugares[(m - 1), (n - 1)] != '-')
                        {
                            lugarLivre = false;
                        }
                        else
                        {
                            lugarLivre = true;
                            lugares[(m - 1), (n - 1)] = char.ToUpper(nomes[a][0]);
                            qC++;
                        }
                    } //valida a disponibilidade e salva o assento
                }
                while (!lugarLivre); //recebe o assento

                if (qC == lugares.Length)
                {
                    lotado = true;
                } //o onibus está lotado

                if (lotado)
                {
                    break;
                } //verifica a lotação
                else
                {
                    do
                    {
                        Console.Write("Deseja reservar o lugar de mais alguém? (S)im ou (N)ão: ");
                        r = char.Parse(Console.ReadLine());
                        r = char.ToUpper(r);
                    } while (r != 'S' && r != 'N'); //confirma o cadastro da segunda pessoa

                    Console.WriteLine();

                    if (r == 'S')
                    {
                        {
                            Console.Write("Informe o seu nome: ");
                            nomes[a] = Console.ReadLine();
                            Console.WriteLine();
                        } //recebe o nome da segunda pessoa

                        do
                        {
                            if (!lugarLivre)
                            {
                                Console.WriteLine("O lugar já está ocupado!");
                            } //o lugar escolhido está ocupado

                            {
                                do
                                {
                                    if (!lugarValido)
                                    {
                                        Console.WriteLine("Fileira inválida!");
                                    } //a fileira escolhida não existe

                                    Console.Write("Informe a fileira que deseja: ");
                                    n = int.Parse(Console.ReadLine());

                                    {
                                        if (n > j || n <= 0)
                                        {
                                            lugarValido = false;
                                        }
                                        else
                                        {
                                            lugarValido = true;
                                        }
                                    } //valida a fileira

                                } while (n > j || n <= 0); //recebe a fileira

                                do
                                {
                                    if (!lugarValido)
                                    {
                                        Console.WriteLine("Cadeira inválida!");
                                    } //a cadeira escolhida não existe

                                    Console.Write("Informe a cadeira que deseja: ");
                                    m = int.Parse(Console.ReadLine());

                                    {
                                        if (m > i || m <= 0)
                                        {
                                            lugarValido = false;
                                        }
                                        else
                                        {
                                            lugarValido = true;
                                        }
                                    } //valida a existência da cadeira

                                } while (m > i || m <= 0); //recebe a cadeira
                            } //recebe o assento

                            {
                                if (lugares[(m - 1), (n - 1)] != '-')
                                {
                                    lugarLivre = false;
                                }
                                else
                                {
                                    lugarLivre = true;
                                    lugares[(m - 1), (n - 1)] = char.ToUpper(nomes[a][0]);
                                    qC++;
                                }
                            } //valida a disponibilidade e salva o assento
                        }
                        while (!lugarLivre); //recebe o lugar da segunda pessoa

                        {
                            Console.Clear();
                            Console.WriteLine("  Lugares atuais");
                            Console.WriteLine();
                            foreach (char lugar in lugares)
                            {
                                Console.Write(" |{0}| ", lugar);
                                c++;
                                if ((c) % j == 0)
                                {
                                    Console.WriteLine();
                                }
                            }
                            Console.WriteLine();
                            c = 0;
                        } //exibe os lugares atuais

                    }  //cadastro da segunda pessoa
                    else
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("  Lugares atuais");
                            Console.WriteLine();
                            foreach (char lugar in lugares)
                            {
                                Console.Write(" |{0}| ", lugar);
                                c++;
                                if ((c) % j == 0)
                                {
                                    Console.WriteLine();
                                }
                            }
                            Console.WriteLine();
                            c = 0;
                        } //exibe os lugares atuais
                    } //exibe os lugares atuais

                    if (qC == lugares.Length)
                    {
                        lotado = true;
                    } //o onibus está lotado

                    if (lotado)
                    {
                        break;
                    } //validade lotação
                } //cadastra, ou não, a segunda pessoa
            } //popula "lugares[,]"

            {
                {
                    Console.Clear();
                    Console.WriteLine("O ônibus já está lotado.");
                    Console.WriteLine();
                    Console.WriteLine("  Lugares atuais");
                    Console.WriteLine();
                    foreach (char lugar in lugares)
                    {
                        Console.Write(" |{0}| ", lugar);
                        c++;
                        if ((c) % j == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                    c = 0;
                } //exibe os lugares atuais
            } //o onibus está lotado

            Console.Write("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
