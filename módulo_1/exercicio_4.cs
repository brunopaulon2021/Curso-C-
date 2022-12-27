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
        String[] Alunos = {"Bruno", "Patrick", "Daniel", "Helio", "Vitor", "Augusto", "Diego", "Michele", "Adriana", "Daniela"};
       
        foreach (String aluno in Alunos)
        {
            Console.WriteLine("Bem-Vindo(a) !" + aluno);
           
        }
           Console.ReadLine();
    }
}