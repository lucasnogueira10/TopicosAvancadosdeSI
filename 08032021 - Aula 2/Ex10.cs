using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex10
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------ Leitura salário e numero de filhos --------");

            double salario, maior = 0, somaSalario = 0, salariosBaixos = 0, somaFilhos = 0;
            int i, filhos;

            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("\nHabitante " + i);
                Console.Write("Informe o salario: R$");
                salario = double.Parse(Console.ReadLine());

                Console.Write("Informe o numero de filhos: ");
                filhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += filhos;

                if (salario < 150)
                    salariosBaixos += 1;

                if (i == 1)
                    maior = salario;
                else
                {
                    if (salario > maior)
                        maior = salario;
                }
            }

            Console.Write("\nA media salarial da populacao: R$" + (somaSalario / (i - 1)));
            Console.Write("\nA media do numero de filhos: " + (somaFilhos / (i - 1)));
            Console.Write("\nA maior salario dos habitantes: R$" + maior);
            Console.Write("\nO percentual de pessoas com salario menor que R$ 150,00: " + ((salariosBaixos / (i - 1)) * 100) + "%");

            Console.ReadKey();
        }
    }
}