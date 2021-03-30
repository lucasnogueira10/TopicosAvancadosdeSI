using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Medir temperatura 5 dias --------");
            double[] temperatura = new double[5];
            double menor = 0, maior = 0, soma = 0;
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Informe a temperatura do " + (i + 1) + "º dia: ");
                temperatura[i] = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    menor = temperatura[i];
                    maior = temperatura[i];
                }
                else
                {
                    if (temperatura[i] > maior)
                        maior = temperatura[i];
                    if (temperatura[i] < menor)
                        menor = temperatura[i];
                }
                soma += temperatura[i];
            }

            Console.Write("\nA menor temperatura é: " + menor + "°C");
            Console.Write("\nA maior temperatura é: " + maior + "°C");
            Console.Write("\nA temperatura media é: " + (soma / i) + "°C");

            Console.ReadKey();
        }
    }
}