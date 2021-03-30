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

            // Declarando Variaveis

            int percentualDistribuidor = 28;
            int percentualImposto = 45;

            double valorCustoFabrica = Convert.ToDouble(Console.ReadLine());

            double custoPercentualDistribuidor = (valorCustoFabrica * percentualDistribuidor) / 100;
            double custoPercentualImposto = (valorCustoFabrica * percentualImposto) / 100;

            double valorTotalConsumidor = valorCustoFabrica + custoPercentualDistribuidor + custoPercentualImposto;

            Console.WriteLine(" O Custo Final Ao Consumidor É: R$ " + valorTotalConsumidor.ToString());

            Console.ReadKey();
        }
    }
}


