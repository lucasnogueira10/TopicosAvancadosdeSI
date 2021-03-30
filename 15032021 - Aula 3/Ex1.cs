using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex1
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("A seguir, informe a quantidade de anos, meses e dias que voce tem");
            Console.Write("Anos: ");
            pessoa.anos = int.Parse(Console.ReadLine());

            Console.Write("Meses: ");
            pessoa.meses = int.Parse(Console.ReadLine());

            Console.Write("Dias: ");
            pessoa.dias = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDias de vida: " + pessoa.CalcularDiasVida());
            Console.ReadKey();
        }
    }
}
