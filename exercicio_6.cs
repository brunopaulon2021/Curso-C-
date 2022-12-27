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
        int horario = 7;

        while (horario >= 7 && horario <= 17)
        {
          Console.WriteLine("São" + horario + "h" + "o mercado está aberto !");
          horario++;
        }
        Console.WriteLine("O mercado acabou de fechar volte amanha");
        Console.ReadLine();
    }
}

/*
3. Crie um programa C# que exiba para os clientes de um mercado que está aberto
sob a condição do seu horário de funcionamento das 7h às 17h após esse horário
exibir uma mensagem de que se encontra fechado e indicando o horário de
funcionamento deste estabelecimento.
*/