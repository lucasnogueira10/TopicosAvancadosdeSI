using Model.Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex3
    {
        static void Main(string[] args)
        {
            Fabrica fabrica = new Fabrica();

            Console.Write("Informe o custo total para a fabrica: R$");
            fabrica.custoFabrica = double.Parse(Console.ReadLine());

            Console.Write("\nCusto total para o consumidor: R$" + fabrica.CalcularCustoTotal());
            Console.ReadKey();
        }
    }
}
