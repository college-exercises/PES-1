using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armazenar o nome, sexo e idade de vinte pessoas. Após a digitação, exibir os dados (nome, sexo e idade) em ordem decrescente de idade
            string[] nomes, sexos;
            int[] idades;
            int n = 0, n2 = 0, qi = 20, a; //indice de loop geral, indice de loop secundário, quantidade de indices do vetor, auxiliar de transferencia
            string aS; //auxiliar de transferencia do tipo String
            nomes = new string[qi]; //instanciação dos vetores
            sexos = new string[qi];
            idades = new int[qi];

            do       //loop para receber os valores do array
            {
                Console.Write("Digite o {0}º nome: ", (n + 1));
                nomes[n] = Console.ReadLine();

                do
                {
                    Console.Write("Digite o sexo. (Use \"F\" ou \"M\": ");
                    sexos[n] = Console.ReadLine();
                }
                while (sexos[n] != "F" && sexos[n] != "f" && sexos[n] != "M" && sexos[n] != "m");

                do
                {
                    Console.Write("Digite a idade: ");
                    idades[n] = int.Parse(Console.ReadLine());
                }
                while (idades[n] <= 0);
                Console.WriteLine();
                n++;
            }
            while (n < qi);
            n = 0;

            while (n < qi)  //loop para percorrer o arrayIdades
            {
                while (n2 < qi) //loop para comparação dos valores de 2 indices
                {
                    if (n2 == (qi - 1)) //condicional para evitar "ultrapassagem" do limite do array
                    {
                        n2++;
                    }
                    else
                    {
                        if (idades[n2] < idades[(n2 + 1)])    //condicional para troca dos valores
                        {
                            a = idades[n2];
                            idades[n2] = idades[n2 + 1];
                            idades[(n2 + 1)] = a;
                            aS = sexos[n2];
                            sexos[n2] = sexos[n2 + 1];
                            sexos[(n2 + 1)] = aS;
                            aS = nomes[n2];
                            nomes[n2] = nomes[n2 + 1];
                            nomes[(n2 + 1)] = aS;
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

            n = 0;

            do
            {
                Console.WriteLine("{0} - {1} - {2}", sexos[n], idades[n], nomes[n]);
                Console.WriteLine();
                n++;
            }
            while (n < qi);

            Console.ReadKey();
        }
    }
}
