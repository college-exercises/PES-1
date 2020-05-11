using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros, numerosI;    //vetor números e, vetor numeros Inicial

            int n = 0, n2 = 0, qi = 20, a; //indice de loop geral, indice de loop secundário, quantidade de indices do vetor, auxiliar de transferencia

            numeros = new int[qi];
            numerosI = new int[qi];

            do                   //loop para receber os valores do array
            {
                Console.Write("Digite o {0}º número: ", (n+1));
                numeros[n] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                n++;
            }
            while (n < qi);
            n = 0;

            Array.Copy(numeros, 0, numerosI, 0, numerosI.Length);       //atribuir os valores do array para um "array Inicial"

            while (n < qi)  //loop para percorrer o arrayNumeros
            {
                while (n2 < qi) //loop para comparação dos valores de 2 indices
                {
                    if (n2 == (qi - 1)) //condicional para evitar "ultrapassagem" do limite do array
                    {
                        n2++;
                    }
                    else
                    {
                        if (numeros[n2] > numeros[(n2 + 1)])    //condicional para troca dos valores
                        {
                            a = numeros[n2];
                            numeros[n2] = numeros[n2 + 1];
                            numeros[(n2 + 1)] = a;
                        }
                        else
                        {
                            n2++;
                        }
                    }
                }
                n2 = 0; //zerar indice
                n++;
            }

            Console.WriteLine("O vetor inicial é o seguinte:");
            Console.WriteLine();

            foreach (int elemento in numerosI)  //exibição do array Inicial
            {
                Console.Write(" {0} ", elemento);
            }
            Console.WriteLine();

            Console.WriteLine("O vetor ordenado é o seguinte:");
            Console.WriteLine();

            foreach (int elemento in numeros)  //exibição do array Ordenado
            {
                Console.Write(" {0} ", elemento);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
