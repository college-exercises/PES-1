using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title="Jogo da Velha";
            int i = 3,
                j = 3,
                c = 1,
                qX = 0,
                qO = 0,
                p0 = 0,
                p1 = 0,
                e = 0;

            char d = 'a',
            posicao = 'a';

            string escolha;

            char[] jogadas = new char[(i * j)];

            string[,] tabuleiro = new string[i, j],
                      tabuleiroBack = new string[i, j];

            string[] jogadores = new string[2];

            bool vitoria = false,
                 empate = false,
                 posicaoInvalida = false;

            do
            {
                {
                    vitoria = false;
                    empate = false;
                    posicaoInvalida = false;
                    posicao = 'a';
                    d = 'a';
                    e = 0;
                } //atribui valores às variáveis

                for (int a = 0; a < (i * j); a++)
                {
                    jogadas[a] = 'z';
                } //atribue 'z' a todas as jogadas

                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        tabuleiro[a, b] = Convert.ToString(d);
                        d++;
                    }
                } //atribui "valores" para o tabuleiro
                c = 0;

                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        tabuleiroBack[a, b] = tabuleiro[a, b];
                    }
                } //faz uma cópia do tabuleiro

                for (int a = 0; a < 2; a++)
                {
                    Console.Write("Informe o nome do jogador {0}: ", (a + 1));
                    jogadores[a] = Console.ReadLine();
                    if (a == 1 && jogadores[a] == jogadores[a - 1])
                    {
                        do
                        {
                            Console.WriteLine("O nome é idêntico!");
                            Console.Write("Informe o nome do jogador {0}: ", (a + 1));
                            jogadores[a] = Console.ReadLine();
                        } while (jogadores[a] == jogadores[a - 1]);
                    }
                } //recebe os nomes dos jogadores

                while (!vitoria && !empate)
                {
                    for (int a = 0; a < 2; a++)
                    {
                        {
                            Console.Clear();
                            Console.WriteLine("  Jogo Atual");
                            Console.WriteLine();
                            foreach (string casa in tabuleiro)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                                if (casa == "X")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                }
                                else
                                {
                                    if (casa == "O")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                }

                                Console.Write(" |{0}| ", casa);
                                c++;
                                if ((c) % j == 0)
                                {
                                    Console.WriteLine();
                                }
                                Console.ResetColor();
                            }
                            Console.WriteLine();
                        } //exibe o jogo atual

                        do
                        {
                            if (posicaoInvalida)
                            {
                                {
                                    Console.Clear();
                                    Console.WriteLine("  Jogo Atual");
                                    Console.WriteLine();
                                    foreach (string casa in tabuleiro)
                                    {
                                        Console.Write(" |{0}| ", casa);
                                        c++;
                                        if ((c) % j == 0)
                                        {
                                            Console.WriteLine();
                                        }
                                    }
                                    Console.WriteLine();
                                } //exibe o jogo atual

                                Console.WriteLine("Posição Inválida!");
                                Console.WriteLine("Tente novamente.");
                                Console.WriteLine();
                            } //recebe a posicao

                            Console.WriteLine("Turno de {0}", jogadores[a]);
                            Console.Write("Digite a posição: ");
                            posicao = char.Parse(Console.ReadLine());

                            switch (posicao)
                            {
                                case 'a':
                                    p0 = 0;
                                    p1 = 0;
                                    if (tabuleiro[0, 0] != Convert.ToString('a'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'b':
                                    p0 = 0;
                                    p1 = 1;
                                    if (tabuleiro[0, 1] != Convert.ToString('b'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'c':
                                    p0 = 0;
                                    p1 = 2;
                                    if (tabuleiro[0, 2] != Convert.ToString('c'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'd':
                                    p0 = 1;
                                    p1 = 0;
                                    if (tabuleiro[1, 0] != Convert.ToString('d'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'e':
                                    p0 = 1;
                                    p1 = 1;
                                    if (tabuleiro[1, 1] != Convert.ToString('e'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'f':
                                    p0 = 1;
                                    p1 = 2;
                                    if (tabuleiro[1, 2] != Convert.ToString('f'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'g':
                                    p0 = 2;
                                    p1 = 0;
                                    if (tabuleiro[2, 0] != Convert.ToString('g'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'h':
                                    p0 = 2;
                                    p1 = 1;
                                    if (tabuleiro[2, 1] != Convert.ToString('h'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                case 'i':
                                    p0 = 2;
                                    p1 = 2;
                                    if (tabuleiro[2, 2] != Convert.ToString('i'))
                                    {
                                        posicaoInvalida = true;
                                    }
                                    else
                                    {
                                        posicaoInvalida = false;
                                    }
                                    break;

                                default:
                                    posicaoInvalida = true;
                                    break;
                            } //verifica a possibilidade da escolha

                            if (tabuleiro[p0, p1] == "X" || tabuleiro[p0, p1] == "O")
                            {
                                posicaoInvalida = true;
                            } //verifica se a posição está vazia

                            if (!posicaoInvalida)
                            {
                                jogadas[e] = posicao;
                            } //salva a jogada

                        } while (posicaoInvalida); //recebe a posicao

                        if (a == 0)
                        {
                            tabuleiro[p0, p1] = "X";
                            qX++;
                        }
                        else
                        {
                            tabuleiro[p0, p1] = "O";
                            qO++;
                        } //simbolo da jogada

                        e++;

                        if (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0])
                        {
                            vitoria = true;
                        }  //1ª vertical
                        else
                        {
                            if (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1])
                            {
                                vitoria = true;
                            }  //2ª vertical
                            else
                            {
                                if (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2])
                                {
                                    vitoria = true;
                                }  //3ª vertical
                                else
                                {
                                    if (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2])
                                    {
                                        vitoria = true;
                                    }  //1ª horizontal
                                    else
                                    {
                                        if (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2])
                                        {
                                            vitoria = true;
                                        }  //2ª horizontal
                                        else
                                        {
                                            if (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2])
                                            {
                                                vitoria = true;
                                            }  //3ª horizontal
                                            else
                                            {
                                                if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
                                                {
                                                    vitoria = true;
                                                }  //diagonal principal
                                                else
                                                {
                                                    if (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                                                    {
                                                        vitoria = true;
                                                    }  //diagonal secundária
                                                    else
                                                    {
                                                        vitoria = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (jogadas[((i * j) - 1)] != 'z')
                        {
                            empate = true;
                            break;
                        } //checa o empate
                        else
                        {
                            if (vitoria)
                            {
                                break;
                            }
                        } //checa a vitoria

                    } //alterna entre jogadores

                } //campo de jogo

                for (int a = 0; a < i; a++)
                {
                    for (int b = 0; b < j; b++)
                    {
                        if (tabuleiro[a, b] != "X" && tabuleiro[a, b] != "O")
                        {
                            tabuleiro[a, b] = "-";
                        }
                    }
                } //preenche os campos vazios com "-"

                {
                    Console.Clear();
                    Console.WriteLine("  Jogo Atual");
                    Console.WriteLine();
                    foreach (string casa in tabuleiro)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        if (casa == "X")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else
                        {
                            if (casa == "O")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        }

                        Console.Write(" |{0}| ", casa);
                        c++;
                        if ((c) % j == 0)
                        {
                            Console.WriteLine();
                        }
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                } //exibe o jogo atual

                if (vitoria)
                {
                    if (qX > qO)
                    {
                        Console.WriteLine("O vencedor é {0}", jogadores[0]);
                    }
                    else
                    {
                        Console.WriteLine("O vencedor é {0}", jogadores[1]);
                    }
                } //checa o vencedor
                else
                {
                    Console.WriteLine("Houve empate");
                } //declara o empate

                {
                    Console.Write("Deseja jogar novamente? (Use \"S\" ou \"N\"):");
                    escolha = Console.ReadLine();
                    Console.WriteLine();
                } //jogar novamente?

            } while (escolha == "S" || escolha == "s"); //desenvolve o jogo

            Console.Write("Pressione qualquel tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
