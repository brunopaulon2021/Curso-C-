using System;
using System.Formats.Asn1;

namespace Exercicio_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exibindo Resultados ....");
            Console.WriteLine("========================");
            float Recebe_area = Pizza(30);
            Console.WriteLine("I'ts Result is" + Recebe_area + "cm");
            Console.ReadLine();
        }

        static float Pizza (int Raio)
        {
            float PI = 3.14f;
            float area = PI * (Raio * Raio);
            return area;
        }

    }
}

/* AREA É A PI X RAIO ELEVADO A 2 */

/*Paulo is a pizza maker who needs to find the area of a circle to
to make the perfect pizza and win the national contest, Create a C# program
making use of the functions, which calculate the area of a circle, receiving the radius value
30 desired by Paul.*/