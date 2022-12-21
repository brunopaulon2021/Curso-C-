using System;

namespace HelloWorld

{
    class Program
    {
        static void Main (string[] args)
        {
            // Int - - 156 como 32334
            // Float - - 15.6 como  232.153 ===> Double \| Decimal
            // String - - sempre sera com "Tipo Texto"
            // Char - sempre sera com aspas simples'Tipo Character'
            // Bool - true ou false

            // Nome deve conter
            // A-Z
            // 0-9 Não podendo estar no começo
            // @ $ Não pode conter caracter especial
            // Separar paravras com _ 
            // cuidado com palavra reservadas (using, static, class)

            int segunda_Guerra_Mundial = 1942;
            string corFavorita = "Purple";
            float velocidadeF1 = 297.0f;
            bool segunda_Guerra_Mundial_existiu = true;
            
            Console.WriteLine(segunda_Guerra_Mundial);
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(segunda_Guerra_Mundial_existiu);
            Console.ReadLine ();

            velocidadeF1 = 350.30f;
            corFavorita = "Gray";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(corFavorita);
        }
    }
}