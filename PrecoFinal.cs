using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public interface PrecoFinal
    {
        static void Main (string[] args){
            LastPrice("chocolate", 30);
            LastPrice("Refrigerant", 50);
            LastPrice("Cake", 45);
            LastPrice("Ice cream", 60);
            LastPrice("Bread", 15);
            Console.ReadLine();
        }

        static int LastPrice (string name , int price) {
            int LastPrice =  (price + 25%);
            Console.WriteLine ( name + "LastPrice is $" + LastPrice);
        }
    }
}

/* 1- Crie um programa em C# que utilize uma Função chamada “ PrecoFinal ” que
ajuste em 25% a mais do valor inicial dos produtos:
● Chocolate: 30
● Refrigerante: 50
● Bolo: 45
● Sorvete: 60
● Pão: 15
exiba o resultado na tela*/