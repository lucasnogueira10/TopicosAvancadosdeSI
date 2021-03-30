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

            // Declaração De Variaveis , mais coletando informações

            int percentualGanhoValorVenda = 5;

            Console.WriteLine("Digite Por favor o Total De Carros Vendidos:");

            int totalCarrosVendidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite Por favor o Valor Total Das Vendas:");

            double ValorTotalVendas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite Por favor o Salario Fixo Do Revendedor:");

            double salarioFixo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite Por favor O Valor Por Carro Vendido:");

            double ValorPagoCarroVendido = Convert.ToDouble(Console.ReadLine());

            //Calculo

            double salarioFinal = salarioFixo + (totalCarrosVendidos * ValorPagoCarroVendido) + ((ValorTotalVendas * percentualGanhoValorVenda) / 100);

            string valorArredondado = Math.Round(salarioFinal, 2).ToString();

            Console.WriteLine("O Salario do Funcionário EH: R$" + valorArredondado);

            Console.ReadKey();
        }
    }
}
