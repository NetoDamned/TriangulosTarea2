using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloTarea2
{
    class Program
    {
        static void Main(string[] args)
        {

            double ladoA, ladoB, ladoC, valor1, valor2, angulo, coseno, resultado1, resultado2, radianes, sp, area;
            string linea;

            Console.WriteLine("Ingresa el 1er lado del triángulo");
            linea = Console.ReadLine();
            ladoA = double.Parse(linea);
            Console.WriteLine("Ingresa el 2do lado del triángulo");
            linea = Console.ReadLine();
            ladoB = double.Parse(linea);
            Console.WriteLine("Ingresa el ángulo que dibujan ambos lados");
            linea = Console.ReadLine();
            angulo = double.Parse(linea);

            valor1 = Math.Pow(ladoA, 2);
            valor2 = Math.Pow(ladoB, 2);

            radianes = (Math.PI / 180) * angulo;
            coseno = Math.Cos(radianes);

            resultado1 = valor1 + valor2 - 2 * ladoA * ladoB * coseno;

            ladoC = Math.Sqrt(resultado1);

            sp = (ladoA + ladoB + ladoC) / 2;
            resultado2 = sp * (sp - ladoA) * (sp - ladoB) * (sp - ladoC);

            area = Math.Sqrt(resultado2);

            Console.WriteLine("El área de tu triángulo es: ");
            Console.WriteLine(area);
            Console.ReadKey();




        }
    }
}
