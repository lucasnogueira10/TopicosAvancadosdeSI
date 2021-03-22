using Model.Ex6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex6

    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();

            Console.Write("Informe o salario: R$");
            vendedor.salario = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor das vendas: R$");
            vendedor.vendas = double.Parse(Console.ReadLine());

            Console.Write("\nSalario total: R$" + vendedor.CalcularSalarioTotal());
            Console.ReadKey();
        }
    }
}
