using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
                //Rotina de entrada que aceita somente valores positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            
            do
            {
                Console.WriteLine("Digite um valor positivo");
                v = int.Parse(Console.ReadLine());
            }
            while (v < 0);
            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
