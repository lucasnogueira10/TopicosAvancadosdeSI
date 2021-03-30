using Model.Ex4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex4
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Informe a quantidade de carros vendidos: ");
            funcionario.carrosVendidos = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor total das vendas: R$");
            funcionario.valorVendas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do salario fixo: R$");
            funcionario.salario = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor da comissao: R$");
            funcionario.comissao = int.Parse(Console.ReadLine());

            Console.Write("\nSalario final: R$" + funcionario.CalcularSalarioFinal());

            Console.ReadKey();
        }
    }
}
