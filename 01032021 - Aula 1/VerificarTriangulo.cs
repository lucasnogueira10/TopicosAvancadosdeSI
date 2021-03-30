using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjExercicio01032021
{
    class VerificarTriangulo
    {
        static void Main(String[] Args)
        {
            //Declaração de Variáveis
            int A;
            int B;
            int C;

            // Nome do programa
            Console.WriteLine("___FORMANDO TRIÂNGULO___");

            //Pedindo as entradas
            Console.WriteLine(" ");
            Console.Write("Informe o lado A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o lado B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.Write("Informe o lado C: ");
            C = Convert.ToInt32(Console.ReadLine());

            //Verificando triangulo 
            if ((A < B + C) && (B < A + C) && (C < A + B))
            {
                Console.WriteLine(" ");
                Console.Write("Formam triângulo!");

                if ((A == B) && (B == C))
                {
                    Console.WriteLine(" ");
                    Console.Write("Triângulo Equilátero");

                }
                else if ((A == B) || (B == C) || (A == C))
                {
                    Console.WriteLine(" ");
                    Console.Write("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.Write("Triângulo Escaleno");
                }

            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("Os valores não formam um triângulo!");
            }
            System.Console.ReadKey();
        }
    }

}
