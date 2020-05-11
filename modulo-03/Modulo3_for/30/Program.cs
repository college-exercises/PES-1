using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30
                //Soma dos elemento de 1 a 100.
                //Sn=(A1+An)*n/2 and An=A1+(n-1)*r
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sn = 0;

            for (int i = 1; i <= 100; i++)
            {
                Sn = Sn + i;
            }

            Console.WriteLine("A soma dos elementos de 1 a 100 é igual a {0}.", Sn);
            Console.ReadKey();
        }
    }
}
