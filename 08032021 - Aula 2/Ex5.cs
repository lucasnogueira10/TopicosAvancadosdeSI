using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex5
    {
        static void Main(string[] args)
        {
            // Declaração das variaveis

            decimal alturaUsuario, pesoIdeal;
            string SexoUsuario;
            bool alturaEhValida;

            // Solicitação De Valores Para O Usuario

            Console.Write("Por Favor Digite Sua Altura Em Metros:");
            alturaEhValida = decimal.TryParse(Console.ReadLine(), out alturaUsuario);

            if (!alturaEhValida)
            {
                Console.WriteLine("O Valor Digitado Não Corresponde A Um Valor Numérico.");
                Environment.Exit(1);
            }

            Console.Write("Sexo [M]asculino / [f]eminino:");

            SexoUsuario = Console.ReadKey().KeyChar.ToString().ToUpper();


            if (SexoUsuario.Equals("M"))
            {
                // Realiza O Calculo Conforme A Situação
                pesoIdeal = alturaUsuario * 72.7m - 58m;
                Console.WriteLine($"\n\nSeu Peso Ideal é {pesoIdeal:N1}kg.");
            }
            else if (SexoUsuario.Equals("F"))
            {
                // Realiza o Calculo  Conforme A Situação
                pesoIdeal = alturaUsuario * 62.1m - 44.7m;
                Console.WriteLine($"\n\nSeu Peso Ideal é {pesoIdeal:N1}kg.");
            }
            else
            {
                Console.WriteLine($"\n\nO valor Digitado ({SexoUsuario}) Não É Um Sexo Válido");

            }

            Console.ReadKey();
        }
    }
}
