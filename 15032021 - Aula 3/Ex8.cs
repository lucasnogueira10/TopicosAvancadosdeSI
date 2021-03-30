using Model.Ex8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Ex8
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            triangulo.InformSideA();
            triangulo.InformSideB();
            triangulo.InformSideC();
            triangulo.ValidateTriangle();

            Console.ReadKey();
        }
    }
}
