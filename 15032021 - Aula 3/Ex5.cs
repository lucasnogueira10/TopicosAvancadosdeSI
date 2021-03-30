using Model.Ex5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Informe o seu nome: ");
            pessoa.nome = Console.ReadLine();

            Console.Write("Informe a sua altura: ");
            pessoa.altura = double.Parse(Console.ReadLine());

            Console.Write("Informe o seu sexo (M/F): ");
            pessoa.sexo = Console.ReadLine();

            Console.Write("\nPeso ideal: " + pessoa.CalcularPesoIdeal() + " Kg");
            Console.ReadKey();
        }
    }
}
