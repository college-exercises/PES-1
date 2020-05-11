using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
                //Aceitar apenas "F" ou "M" como respota para o sexo.
                                                                            //NÃO SE PODE FAZER COM O "FOR"
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;

            do
            {
                Console.WriteLine("Qual o seu sexo? Responda apenas com F ou M.");
                sexo = Console.ReadLine();
            }
            while (sexo != "F" & sexo != "M");

            Console.WriteLine("Pressione qualquer tecla para fechar o programa");
            Console.ReadKey();
        }
    }
}
