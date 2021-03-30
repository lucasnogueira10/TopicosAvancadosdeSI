using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class Equa2Grau
    {
        static void Main(string[] args)
        {

            // Declaracao das variaveis
            double a, b, c, delta, x1, x2;

            //Entrada de dados

            Console.Write("Digite o valor de A:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B:");
            b = double.Parse(Console.ReadLine());
             
            Console.Write("Digite o valor de C:");
            c = double.Parse(Console.ReadLine());

            // Processamento

            delta = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("\nO valor de Delta é: " + delta);

            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;

            if(delta>0)
            {
                Console.WriteLine("\n\nEXISTEM 2 RAIZES REAIS DIFERENTES.X1:" + x1 + " e X2:" + x2);
            }else if (delta == 0)
            {
                Console.WriteLine("\n\nEXISTEM 2 RAIZES IGUAIS  + X1:" + x1 + " e X2:" + x2);
            }
              else
            {
                Console.WriteLine("\n\nNÃO EXISTEM RAIZES REAIS!");
            }

            Console.ReadKey();

        }
    }
}
