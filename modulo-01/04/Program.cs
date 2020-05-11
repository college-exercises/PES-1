using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
                //Média aritmética
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, m; //notas (1, 2, 3 e 4), média

            Console.Write("Digite a primeira nota");
            n1 = double.Parse(Console.ReadLine()); //recebe a nota 1
            Console.Write("Digite a segunda nota");
            n2 = double.Parse(Console.ReadLine()); //recebe a nota 2
            Console.Write("Digite a terceira nota");
            n3 = double.Parse(Console.ReadLine()); //recebe a nota 3
            Console.Write("Digite a quarta nota");
            n4 = double.Parse(Console.ReadLine()); //recebe a nota 4

            m = (n1 + n2 + n3 + n4) / 4; //fórmula para calcular a média

            Console.Write("A media dos quatro numeros é {0}", m); ///exibe a média
            Console.ReadKey();
        }
    }
}
