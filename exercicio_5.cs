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
           for (int velocidadeIncial = 0; velocidadeIncial <= 200; velocidadeIncial++)
           {
            Console.WriteLine("Acelerando...");
            Console.WriteLine(velocidadeIncial);
             Console.WriteLine("km");

           }
           Console.WriteLine("Chegamos a velocidade maxima...");
           Console.ReadLine();
    }
}

/*2. Crie um programa C# usando as estruturas de repetição que contabilize a
velocidade de um carro de fórmula 1, sem ultrapassar o limite de 200 Km/h permitido
na pista, exiba uma mensagem no final informando que chegou no limite.*/