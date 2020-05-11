using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
            //Tabuada do 1 ao 20, cominteração do usuário entre elas.
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, r, i, n = 1;  
             /* a = variável de valor estático, apenas para podermos retornar o "i" para "1", foi criada visando mudanças futuras no código
             *  r = variável "resultado", atribui-se a ela a o resultado da multiplicação atual
             *  i = variável "indice de tabuada", varia de "1 a 10", gera o valor que será multiplicado com variável "a"
             *  n = variável "indice de loop Geral", seu valor é acrescido em "1" a cada loop, marca a contagem até "20"
             */

            while (n<=20)   //Laço para impressão das taduadas, inicio = 1, término = 20
            {
                i = a;  //Atribuição de "a" em "i"
                Console.WriteLine();    //Quebra de linha para puro capricho visual
                Console.WriteLine("Tabuada do {0}", n); //"Título de da tabuada"
                Console.WriteLine();

                while (i <= 10) //Laço para immpressão das "linhas" da tabuada
                {
                    r = n * i;  //Fórmula para cálculo do resultado
                    Console.WriteLine("{0} x {1} = {2}", n, i, r);  //Impressão do resultado
                    i++;    //Variação do indice de tabuada
                }

                if (n == 20)    //Condição para validar, ou não, a solicitação para a exibição da próxima tabuada.
                {
                    break;  //Se verdadeira, ou seja, o indice geral já for igual a "20", então encerre o loop
                }
                else   //Se falsa, Oeça interação do usuário
                {
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para exibir a tabuada do {0}", (n + 1));
                    n++;
                    Console.ReadKey();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");   //Instrução final para fechamento do programa
            Console.ReadKey();
        }
    }
}
