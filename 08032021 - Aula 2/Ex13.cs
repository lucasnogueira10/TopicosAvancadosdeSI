using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex13
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------ Leitor de numeros inteiros --------");

            int n;
            do
            {
                Console.Write("\nInforme um numero maior ou igual a 0: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("O numero deve ser maior ou igual a 0.");
            } while (n <= 0);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}