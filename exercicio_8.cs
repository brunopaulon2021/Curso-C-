using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text;


public class HelloWorld
{
    
    static void Main(string[] args)
        {
          Console.WriteLine("A Contagem foi iniciada!");
           for (int contador = 1000; contador >= 0 ; contador--)
           {
            Console.WriteLine("Timer :");
            Console.WriteLine(contador);

           }
           Console.WriteLine("O Foguete foi lançado com sucesso!");
            Console.ReadLine( );
        }
}

/*
4. Utilizando as estruturas de repetição, crie um programa C# que Realize uma
Contagem regressiva de 1000 a 1 para que um foguete seja lançado ao espaço.
*/