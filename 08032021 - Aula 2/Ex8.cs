using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula08032021
{
    class Ex8
    {
        static void Main(string[] args)
        {
            //Declaração de Variáveis
            int A = 0;
            int B = 0;
            int C = 0;

            // Nome do programa
            Console.WriteLine("___FORMANDO TRIÂNGULO___");

            //Pedindo as entradas

            string msg = " Os Valores Informados Não Representa Um triangulo";

            Console.Write("Informe o lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            //Verificando triangulo 
            if ((A < B + C) && (B < A + C) && (C < A + B))
            {
                msg = "!!FORMAM UM TRIANGULO!!";
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
