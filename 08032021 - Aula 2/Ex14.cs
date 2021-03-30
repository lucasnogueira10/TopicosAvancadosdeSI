using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex14
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------ Média aritimética --------");

            double soma = 0;
            int contador = 0;

            for (int i = 15; i <= 100; i++)
            {
                soma += i;
                contador += 1;
            }

            Console.Write("A media aritmetica dos números entre 15 e 100 é: " + (soma / contador));
            Console.ReadKey();
        }
    }
}