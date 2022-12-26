using System;
using System.Formats.Asn1;
namespace Exercicio_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibindo Resultados ....");
            Console.WriteLine("========================");
            float Recebe_area = Terreno(250, 350);
            Console.WriteLine("I'ts Result is" + Recebe_area + "m²");
            Console.ReadLine();
        }

        static int Terreno(int Base, int Altura)
        {
            int Area = (Base * Altura) / 2;
            return Area;
        }

    }
}

/* AREA É A PI X RAIO ELEVADO A 2 */

/*Paulo is a pizza maker who needs to find the area of a circle to
to make the perfect pizza and win the national contest, Create a C# program
making use of the functions, which calculate the area of a circle, receiving the radius value
30 desired by Paul.*/