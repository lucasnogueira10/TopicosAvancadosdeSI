using Model.Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Urna urna = new Urna();

            Console.Write("Informe a quantidade de eleitores no municipio: ");
            urna.eleitores = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de votos brancos: ");
            urna.votosBrancos = double.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de votos nulos: ");
            urna.votosNulos = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Informe a quantidade de votos validos: ");
                urna.votosValidos = int.Parse(Console.ReadLine());

                if (urna.ValidarVotos())
                    urna.CalcularPercentuais();
                else
                    Console.WriteLine("\nA soma de todos os votos deve ser igual ao número de eleitores!");
            } while (urna.ValidarVotos() == false);

            Console.ReadKey();
        }
    }
}