using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------ Ler 3 valores --------");


            Console.WriteLine("Digite o Primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro valor:");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if ((valor1 == valor2) && (valor2 == valor3) && (valor3 == valor1))
            {
                Console.WriteLine("ERRO !! OS VALORES NAO PODEM SER IGUAIS !! ");
            }
            else if ((valor1 > valor2) && (valor1 > valor3))

                Console.WriteLine("O MAIOR VALOR É:" + valor1);

            else if ((valor2 > valor1) && (valor2 > valor3))

                Console.WriteLine("O MAIOR VALOR É:" + valor2);

            else if ((valor3 > valor1) && (valor3 > valor2))

                Console.WriteLine("O MAIOR VALOR É:" + valor3);

            Console.ReadKey();
        }
    }
}
