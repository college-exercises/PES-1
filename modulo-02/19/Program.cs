using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 5, mediaAluno, p1, p2;   //média do colégio, média do aluno, nota da prova1, nota da prova2

            Console.WriteLine("Digite a nota da P1");
            p1 = double.Parse(Console.ReadLine());  //entrada da prova1
            Console.WriteLine("Digite a nota da P2");
            p2 = double.Parse(Console.ReadLine());  //entrada da prova2

            if (p1 >= 0 && p1 <= 10 && p2 >= 0 && p2 <= 10) //condicional para checar se as notas estão entre o intervalo aceitável. "1" a "10"
            {
                mediaAluno = (p1 + 2 * p2) / 3; //cálculo da média

                if (mediaAluno>=media)  //condicional(is) para checar se o aluno foi, ou não, aprovado
                {
                    Console.WriteLine("O aluno obteve média {0:f1} e foi APROVADO.", mediaAluno);
                }
                else
                {
                    Console.WriteLine("O aluno obteve média {0:f1} e foi REPROVADO.", mediaAluno);
                }
            }
            else
            {
                Console.WriteLine("O intervalo de notas está compreendido entre 0 e 10!");
            }

            Console.ReadKey();
        }
    }
}
