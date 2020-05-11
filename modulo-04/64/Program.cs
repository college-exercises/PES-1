using System;
using System.IO;

namespace _64
{
    class Program
    {
        static void Main(string[] args)
        {
            //como identifcar numero e letras no csharp

            bool invalido = false, ocupado = false, lotado = false, lotadoManha = false, lotadoTarde = false, lotadoNoite = false;

            int x = 0, y = 0, m = 0, n = 0, oManha = 0, oTarde = 0, oNoite = 0, limite = 0, sessao = 1;

            char[,] teatro, manha, tarde, noite;

            char v = 'v', nomeC = char.MinValue;

            string nome = "Angelo";

            {
                do
                {
                    if (invalido)
                    {
                        Console.Clear();
                        Console.WriteLine("O valor escolhido é inválido!");
                        Console.WriteLine();
                    }

                recebeX:
                    try
                    {
                        Console.Write("Informe a quantidade \"X\" de fileiras do teatro: ");
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Há algo de errado com o valor!");
                        goto recebeX;
                        throw;
                    }

                    if (x <= 0)
                    {
                        invalido = true;
                    }
                    else
                    {
                        invalido = false;
                    }

                } while (invalido); //recebe X
                invalido = false;
                Console.Clear();

                do
                {
                    if (invalido)
                    {
                        Console.Clear();
                        Console.WriteLine("O valor escolhido é inválido!");
                        Console.WriteLine();
                    }

                recebeY:
                    try
                    {
                        Console.Write("Informe a quantidade \"Y\" de cadeiras do teatro: ");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Há algo de errado com o valor!");
                        goto recebeY;
                        throw;
                    }

                    if (y <= 0)
                    {
                        invalido = true;
                    }
                    else
                    {
                        invalido = false;
                    }

                } while (invalido); //recebe Y
                invalido = false;
                Console.Clear();
            } //recebe as dimensoes do teatro

            teatro = new char[x, y];
            manha = new char[x, y];
            tarde = new char[x, y];
            noite = new char[x, y];
            limite = (4 * (x * y) / 5);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    teatro[i, j] = v;
                    manha[i, j] = v;
                    tarde[i, j] = v;
                    noite[i, j] = v;
                }
            } //popula teatro e suas sessões

            do
            {
                {
                    if (oManha >= limite)
                    {
                        lotadoManha = true;
                    } //verifica lotação Manha
                    if (oTarde >= limite)
                    {
                        lotadoTarde = true;
                    } //verifica lotação Tarde
                    if (oNoite >= limite)
                    {
                        lotadoNoite = true;
                    } //verifica lotação Noite
                } //verifica lotação Individual
                if (lotadoManha && lotadoTarde && lotadoNoite)
                {
                    lotado = true;
                    break;
                } //varefica lotação Teatro

                if (!invalido && !lotado)
                {
                    Console.Write("Informe o seu nome: ");
                    nome = Console.ReadLine();
                    nome = nome.ToUpper();
                    nomeC = Convert.ToChar(nome[0]);
                    Console.Clear();
                }  //recebe o nome

                Console.Clear();
                Console.WriteLine("\"\"SESSÕES\"\"");
                Console.WriteLine();

                do
                {
                    if (invalido)
                    {
                        Console.WriteLine("A sessão escolhida estava lotada!");
                        Console.WriteLine();
                    }

                    if (sessao <= 0 || sessao > 3)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Sessão inválida!");
                        Console.WriteLine();

                    }

                    {
                        if (!lotadoManha)
                        {
                            Console.WriteLine("Manhã    -   1");
                        }
                        else
                        {
                            Console.WriteLine("Manhã    -   LOTADO");
                        }

                        if (!lotadoTarde)
                        {
                            Console.WriteLine("Tarde    -   2");
                        }
                        else
                        {
                            Console.WriteLine("Tarde    -   LOTADO");
                        }

                        if (!lotadoNoite)
                        {
                            Console.WriteLine("Noite    -   3");
                        }
                        else
                        {
                            Console.WriteLine("Noite    -   LOTADO");
                        }
                        Console.WriteLine();
                    } //exibe as sessoes

                    Console.Write("Informe a sessão desejada: ");
                    sessao = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (sessao <= 0 || sessao > 3); //recebe a sessao

                switch (sessao)
                {
                    case 1:
                        if (lotadoManha)
                        {
                            Console.WriteLine("A sessão está lotada!");
                            invalido = true;
                        }
                        else
                        {
                            invalido = false;
                            do
                            {
                                if (ocupado)
                                {
                                    Console.WriteLine("O lugar escolhido já está ocupado!");
                                    Console.WriteLine();
                                }

                                {
                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A fileira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a fileira que deseja: ");
                                        m = int.Parse(Console.ReadLine());

                                        if (m <= 0 || m > x)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da fileira

                                    } while (invalido); //recebe a fileira
                                    invalido = false;

                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A cadeira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a cadeira que deseja: ");
                                        n = int.Parse(Console.ReadLine());

                                        if (n <= 0 || n > y)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da cadeira
                                    } while (invalido); //recebe a cadeira
                                    invalido = false;
                                } //recebe o assento

                                if (manha[(m - 1), (n - 1)] != v)
                                {
                                    ocupado = true;
                                }
                                else
                                {
                                    ocupado = false;
                                }
                            } while (ocupado); //recebe o assento e valida o assento
                            ocupado = false;
                            manha[(m - 1), (n - 1)] = nomeC;
                            oManha++;

                            if (oManha == limite)
                            {
                                lotadoManha = true;
                            } //verifica lotação
                            else
                            {
                                Console.Write("Você deseja realizar outra reserva? Use \"S\" ou \"N\": ");
                                if (Console.ReadLine().ToUpper() == "S")
                                {
                                    {
                                        Console.Write("Informe o seu nome: ");
                                        nome = Console.ReadLine();
                                        nome = nome.ToUpper();
                                        nomeC = Convert.ToChar(nome[0]);
                                        Console.Clear();
                                    } //recebe o nome

                                    do
                                    {
                                        if (ocupado)
                                        {
                                            Console.WriteLine("O lugar escolhido já está ocupado!");
                                            Console.WriteLine();
                                        }

                                        {
                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A fileira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a fileira que deseja: ");
                                                m = int.Parse(Console.ReadLine());

                                                {
                                                    if (m <= 0 || m > x)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira
                                            } while (invalido); //recebe a fileira
                                            invalido = false;

                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A cadeira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a cadeira que deseja: ");
                                                n = int.Parse(Console.ReadLine());

                                                {
                                                    if (n <= 0 || n > y)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira

                                            } while (invalido); //recebe a cadeira
                                            invalido = false;
                                        } //recebe o assento

                                        if (manha[(m - 1), (n - 1)] != v)
                                        {
                                            ocupado = true;
                                        }
                                        else
                                        {
                                            ocupado = false;
                                        }
                                    } while (ocupado); //recebe o assento e valida o assento
                                    ocupado = false;
                                    manha[(m - 1), (n - 1)] = nomeC;
                                    oManha++;

                                    Console.WriteLine("Sessão manhã");
                                    Console.WriteLine();
                                    for (int i = 0; i < x; i++)
                                    {

                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", manha[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Manha
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                } //será realizada outra reserva
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sessão manhã");
                                    Console.WriteLine();
                                    for (int i = 0; i < x; i++)
                                    {
                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", manha[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Manha
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();

                                } //exibe a sessao
                                if (oManha == limite)
                                {
                                    lotadoManha = true;
                                } //verifica lotação
                            }
                        }
                        break;

                    case 2:
                        if (lotadoTarde)
                        {
                            Console.WriteLine("A sessão está lotada!");
                            invalido = true;
                        }
                        else
                        {
                            invalido = false;
                            do
                            {
                                if (ocupado)
                                {
                                    Console.WriteLine("O lugar escolhido já está ocupado!");
                                    Console.WriteLine();
                                }

                                {
                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A fileira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a fileira que deseja: ");
                                        m = int.Parse(Console.ReadLine());

                                        if (m <= 0 || m > x)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da fileira

                                    } while (invalido); //recebe a fileira
                                    invalido = false;

                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A cadeira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a cadeira que deseja: ");
                                        n = int.Parse(Console.ReadLine());

                                        if (n <= 0 || n > y)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da cadeira
                                    } while (invalido); //recebe a cadeira
                                    invalido = false;
                                } //recebe o assento

                                if (tarde[(m - 1), (n - 1)] != v)
                                {
                                    ocupado = true;
                                }
                                else
                                {
                                    ocupado = false;
                                }
                            } while (ocupado); //recebe o assento e valida o assento
                            ocupado = false;
                            tarde[(m - 1), (n - 1)] = nomeC;
                            oTarde++;

                            if (oTarde == limite)
                            {
                                lotadoTarde = true;
                            } //verifica lotação
                            else
                            {
                                Console.Write("Você deseja realizar outra reserva? Use \"S\" ou \"N\": ");
                                if (Console.ReadLine().ToUpper() == "S")
                                {
                                    {
                                        Console.Write("Informe o seu nome: ");
                                        nome = Console.ReadLine();
                                        nome = nome.ToUpper();
                                        nomeC = Convert.ToChar(nome[0]);
                                        Console.Clear();
                                    } //recebe o nome

                                    do
                                    {
                                        if (ocupado)
                                        {
                                            Console.WriteLine("O lugar escolhido já está ocupado!");
                                            Console.WriteLine();
                                        }

                                        {
                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A fileira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a fileira que deseja: ");
                                                m = int.Parse(Console.ReadLine());

                                                {
                                                    if (m <= 0 || m > x)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira
                                            } while (invalido); //recebe a fileira
                                            invalido = false;

                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A cadeira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a cadeira que deseja: ");
                                                n = int.Parse(Console.ReadLine());

                                                {
                                                    if (n <= 0 || n > y)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira

                                            } while (invalido); //recebe a cadeira
                                            invalido = false;
                                        } //recebe o assento

                                        if (tarde[(m - 1), (n - 1)] != v)
                                        {
                                            ocupado = true;
                                        }
                                        else
                                        {
                                            ocupado = false;
                                        }
                                    } while (ocupado); //recebe o assento e valida o assento
                                    ocupado = false;
                                    tarde[(m - 1), (n - 1)] = nomeC;
                                    oTarde++;

                                    Console.WriteLine("Sessão manhã");
                                    Console.WriteLine();

                                    for (int i = 0; i < x; i++)
                                    {
                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", tarde[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Tarde
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                } //será realizada outra reserva
                                else
                                {

                                    Console.WriteLine("Sessão manhã");
                                    Console.WriteLine();
                                    Console.Clear();
                                    for (int i = 0; i < x; i++)
                                    {
                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", tarde[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Tarde
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();

                                } //exibe a sessao
                                if (oTarde == limite)
                                {
                                    lotadoTarde = true;
                                } //verifica lotação
                            }
                        }
                        break;

                    case 3:
                        if (lotadoNoite)
                        {
                            Console.WriteLine("A sessão está lotada!");
                            invalido = true;
                        }
                        else
                        {
                            invalido = false;
                            do
                            {
                                if (ocupado)
                                {
                                    Console.WriteLine("O lugar escolhido já está ocupado!");
                                    Console.WriteLine();
                                }

                                {
                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A fileira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a fileira que deseja: ");
                                        m = int.Parse(Console.ReadLine());

                                        if (m <= 0 || m > x)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da fileira

                                    } while (invalido); //recebe a fileira
                                    invalido = false;

                                    do
                                    {
                                        if (invalido)
                                        {
                                            Console.WriteLine("A cadeira escolhida não existe!");
                                            Console.WriteLine();
                                        }

                                        Console.Write("Informe a cadeira que deseja: ");
                                        n = int.Parse(Console.ReadLine());

                                        if (n <= 0 || n > y)
                                        {
                                            invalido = true;
                                        }
                                        else
                                        {
                                            invalido = false;
                                        } //valida existencia da cadeira
                                    } while (invalido); //recebe a cadeira
                                    invalido = false;
                                } //recebe o assento

                                if (noite[(m - 1), (n - 1)] != v)
                                {
                                    ocupado = true;
                                }
                                else
                                {
                                    ocupado = false;
                                }
                            } while (ocupado); //recebe o assento e valida o assento
                            ocupado = false;
                            noite[(m - 1), (n - 1)] = nomeC;
                            oNoite++;

                            if (oNoite == limite)
                            {
                                lotadoNoite = true;
                            } //verifica lotação
                            else
                            {
                                Console.Write("Você deseja realizar outra reserva? Use \"S\" ou \"N\": ");
                                if (Console.ReadLine().ToUpper() == "S")
                                {
                                    {
                                        Console.Write("Informe o seu nome: ");
                                        nome = Console.ReadLine();
                                        nome = nome.ToUpper();
                                        nomeC = Convert.ToChar(nome[0]);
                                        Console.Clear();
                                    } //recebe o nome

                                    do
                                    {
                                        if (ocupado)
                                        {
                                            Console.WriteLine("O lugar escolhido já está ocupado!");
                                            Console.WriteLine();
                                        }

                                        {
                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A fileira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a fileira que deseja: ");
                                                m = int.Parse(Console.ReadLine());

                                                {
                                                    if (m <= 0 || m > x)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira
                                            } while (invalido); //recebe a fileira
                                            invalido = false;

                                            do
                                            {
                                                if (invalido)
                                                {
                                                    Console.WriteLine("A cadeira escolhida não existe!");
                                                    Console.WriteLine();
                                                }

                                                Console.Write("Informe a cadeira que deseja: ");
                                                n = int.Parse(Console.ReadLine());

                                                {
                                                    if (n <= 0 || n > y)
                                                    {
                                                        invalido = true;
                                                    }
                                                    else
                                                    {
                                                        invalido = false;
                                                    }
                                                } //valida existencia da cadeira

                                            } while (invalido); //recebe a cadeira
                                            invalido = false;
                                        } //recebe o assento

                                        if (noite[(m - 1), (n - 1)] != v)
                                        {
                                            ocupado = true;
                                        }
                                        else
                                        {
                                            ocupado = false;
                                        }
                                    } while (ocupado); //recebe o assento e valida o assento
                                    ocupado = false;
                                    noite[(m - 1), (n - 1)] = nomeC;
                                    oNoite++;


                                    Console.WriteLine("Sessão noite");
                                    Console.WriteLine();
                                    for (int i = 0; i < x; i++)
                                    {
                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", noite[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Noite
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();
                                } //será realizada outra reserva
                                else
                                {
                                    Console.WriteLine("Sessão manhã");
                                    Console.WriteLine();
                                    Console.Clear();
                                    for (int i = 0; i < x; i++)
                                    {
                                        for (int j = 0; j < y; j++)
                                        {
                                            Console.Write("|{0}|", noite[i, j]);
                                        }
                                        Console.WriteLine();
                                    } //exibe a sessao Noite
                                    Console.Write("Pressione qualquer tecla para continuar.");
                                    Console.ReadKey();
                                    Console.Clear();

                                } //exibe a sessao
                                if (oNoite == limite)
                                {
                                    lotadoNoite = true;
                                } //verifica lotação
                            }
                        }
                        break;
                } //realiza as reservas

                if (lotadoManha && lotadoTarde && lotadoNoite)
                {
                    lotado = true;
                } //varefica lotação Teatro

            } while (!lotado); //realiza as reservas

            Console.Clear();

            Console.WriteLine("O teatro está lotado!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para gerar o arquivo");
            Console.Clear();
            Console.Write("Criando arquivo");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(600);
            }
            Console.Clear();

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            try
            {
                ostrm = new FileStream("./Reservas.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
                Console.WriteLine("Arquivo gerado com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Não foi possível escrever no arquivo!");
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            } //cria arquivo

            Console.SetOut(writer);
            {
                Console.WriteLine("Todas as sessões já estão lotadas!");
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Sessão \"Manhã\":");
                Console.WriteLine();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("|{0}|", manha[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Sessão \"Tarde\":");
                Console.WriteLine();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("|{0}|", tarde[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Sessão \"Noite\":");
                Console.WriteLine();
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("|{0}|", noite[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            } //exibe as sessões

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
