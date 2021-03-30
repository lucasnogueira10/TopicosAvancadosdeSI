using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex9
    {
        static void Main(string[] args)
        {
            double preco, maior = 0, soma = 0;
            int i;

            Console.WriteLine("------ Ler preços dos produtos --------");

            for (i = 1; i <= 15; i++)
            
            {
                Console.Write("Lendo o código do " + i + "º produto...\n...\n");
                Console.Write("Informe o preco do " + i + "º produto: R$");
                preco = double.Parse(Console.ReadLine());
                soma += preco;
                if (i == 1)
                    maior = preco;
                else
                {
                    if (preco > maior)
                        maior = preco;
                }
            }

            
            Console.Write("\nO maior preço é: R$" + maior);
            Console.Write("\nMedia aritmética dos produtos: R$" + (soma / (i - 1)));

            Console.ReadKey();
        }
    }
}