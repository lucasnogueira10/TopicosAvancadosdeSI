using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class Ex2   
    {
        static void Main(string[] args)
        {

            // Declaracao das variaveis
            int VotoBranco, VotoValido, VotoNulo;


            Console.WriteLine("------ Eleitores Percentual --------");

            Console.Write("Digite o total de votos nulos: ");
            VotoNulo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o total de votos brancos: ");
            VotoBranco = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de votos validos:");
            VotoValido = Convert.ToInt32(Console.ReadLine());

            double TotalEleitores = VotoNulo + VotoValido + VotoBranco;

            if (VotoNulo <= 0){
                Console.Write("Valor de votos nulos incompativel");
            }
            else{
                Console.Write("\nQuantidade de votos nulos: " + VotoNulo);
                Console.WriteLine("\nPorcentagem de Votos Nulos: "+ (100 * VotoNulo/TotalEleitores) + "%");
            }
            if (VotoBranco <= 0)
            {
                Console.Write("\nValor de votos brancos incompativel");
            }
            else
            {
                Console.Write("\nQuantidade de votos brancos: " + VotoBranco);
                Console.WriteLine("\nPorcentagem de Votos Brancos: " + (100 * VotoBranco/TotalEleitores) + "%");
            }

            if (VotoValido <= 0)
            {
                Console.Write("\nValor de votos validos incompativel");
            }
            else
            {
                Console.Write("\nQuantidade de votos validos: " + VotoValido);
                Console.WriteLine("\nPorcentagem de Votos Validos: "+ (100 * (VotoValido / TotalEleitores))+ "%");
            }

            if (TotalEleitores <= 0)
            {
                Console.Write("\nTotal de Eleitores inválido");
            }
            else
            {
                Console.Write("\nNumero de eleitores são: " + TotalEleitores);
            }
            System.Console.ReadKey();

        }
    }
}