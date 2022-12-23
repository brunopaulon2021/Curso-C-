using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public interface Program
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

/* 1- Create a program in C# that uses a Function called “ PrecoFinal ” that
adjust by 25% more than the initial value of the products:
● Chocolate: 30
● Soda: 50
● Cake: 45
● Ice cream: 60
● Bread: 15
display the result on the screen */