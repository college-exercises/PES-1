using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;  //opção
            double a, b, div, adicao, sub, mult; //valor1, valor2, resultado da divisão, result adição, result sub e result mult.

            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine();
            Console.WriteLine("1 - Multiplicação");
            Console.WriteLine("2 - Adição");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Subtração");
            Console.WriteLine("5 - Fim de processo");
            Console.WriteLine();
            op = Console.ReadLine();    //entrada da opção

            if (op == "1" || op == "M")
            {
                Console.WriteLine("Digite o primeiro valor");
                a = double.Parse(Console.ReadLine());   //entrada do valor1
                Console.WriteLine("Digite o segundo valor");
                b = double.Parse(Console.ReadLine());   //entrada do valor2
                mult = a * b; //calculo da multiplicação
                Console.WriteLine("O resultado da multiplicação entre {0} e {1} resulta em {2}", a, b, mult);
            }
            else
            {
                if (op == "2" || op == "A")
                {
                    Console.WriteLine("Digite o primeiro valor");
                    a = double.Parse(Console.ReadLine());   //entrada do valor1
                    Console.WriteLine("Digite o segundo valor");
                    b = double.Parse(Console.ReadLine());   //entrada do valor2
                    adicao = a + b; //calculo da adição
                    Console.WriteLine("O resultado da adicao entre {0} e {1} resulta em {2}", a, b, adicao);
                }
                else
                {
                    if (op == "3" || op == "D")
                    {
                        Console.WriteLine("Digite o primeiro valor");
                        a = double.Parse(Console.ReadLine());   //entrada do valor1
                        Console.WriteLine("Digite o segundo valor");
                        b = double.Parse(Console.ReadLine());   //entrada do valor2
                        if (b != 0) //condicional para checar se o valor2 é igual a "0"
                        {
                            div = a / b;    //calculo da divisão
                            Console.WriteLine("O resultado da razão entre {0} e {1} resulta em {2}", a, b, div);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir um número por 0.");
                        }
                    }
                    else
                    {
                        if (op == "4" || op == "S")
                        {
                            Console.WriteLine("Digite o primeiro valor");
                            a = double.Parse(Console.ReadLine());   //entrada do valor1
                            Console.WriteLine("Digite o segundo valor");
                            b = double.Parse(Console.ReadLine());   //entrada do valor2
                            sub = a - b; //calculo da subtração
                            Console.WriteLine("O resultado da subtracao entre {0} e {1} resulta em {2}", a, b, sub);
                        }
                        else
                        {
                            if (op == "5" || op == "F")
                            {
                                Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
                            }
                            else
                            {
                                Console.WriteLine("Há algo de errado aqui, avalie novamente suas opções.");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
