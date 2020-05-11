using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
                //Exibir a tabuada do 5, 1 a  10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=1, r;
            
            Console.WriteLine("Tabuada do 5");

            do
            {
                r = n * 5;
                Console.WriteLine("{0} x 5 = {1}", n, r);
                n++;
            } while (n <= 10);

            Console.WriteLine("Pressione qualquer tecla para fechar o programa.");
            Console.ReadKey();
        }
    }
}
