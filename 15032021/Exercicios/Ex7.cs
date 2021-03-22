using Model.Ex7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex7
    {
        static void Main(string[] args)
        {
            Dado dado = new Dado();

            Console.Write("\nMaior: " + dado.FindBigger());
            Console.ReadKey();
        }
    }
}
