using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2;  //notas das provas 1 e 2

            Console.WriteLine("Digite a nota da P1");
            p1 = double.Parse(Console.ReadLine());  //entrada da prova 1
            p2 = (15 - p1) / 2; //fórmula para cálculo da nota mínita na prova 2 para garantir aprovação

            if (p1>=0 && p1<=10)    //condicional para checar se a nota está no intervalo aceitável
            {
                Console.WriteLine("O aluno deve tirar no mínimo {0:f1} na  segunda prova para ser aprovado",  p2);
            }
            else
            {
                Console.WriteLine("O intervalo de notas está compreendido entre \"0\" e \"10\"");
            }
            Console.ReadKey();
        }
    }
}
