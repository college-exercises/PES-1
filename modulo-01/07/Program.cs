using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
                //Recebe os valores de cinco produtos, o valor pago, e, se houver, exibe o troco.
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, v3, v4, v5, p, t, somaProdutos;

            Console.WriteLine("Digite o Primeiro valor");
            v1 = double.Parse(Console.ReadLine()); //recebe o valor 1
            Console.WriteLine("Digite o Segundo valor");
            v2 = double.Parse(Console.ReadLine()); //recebe o valor 2
            Console.WriteLine("Digite o Terceiro valor");
            v3 = double.Parse(Console.ReadLine()); //recebe o valor 3
            Console.WriteLine("Digite o Quarto valor");
            v4 = double.Parse(Console.ReadLine()); //recebe o valor 4
            Console.WriteLine("Digite o Quinto valor");
            v5 = double.Parse(Console.ReadLine()); //recebe o valor 5
            Console.WriteLine("Digite o valor pago");
            p = double.Parse(Console.ReadLine()); //recebe o valor pago

            somaProdutos = v1 + v2 + v3 + v4 + v5; //soma dos preços
            t = p - somaProdutos; //cálculo do troco

            if (somaProdutos > t)           //Condicional para saber se há ou não troco
            {
                Console.Write("O valor da compra excede o valor pago em R${0}", t); //exibe mensagem falando que não houve troco
            }
            else
            {
                Console.Write("A compra custou R${0}, e o troco foi de R${1}", somaProdutos, t); //exibe o troco
            }
            Console.ReadKey();
        }
    }
}
