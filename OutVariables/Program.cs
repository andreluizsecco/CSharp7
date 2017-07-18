using System;

namespace OutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidarNumeroInteiroComum("1");
            ValidarNumeroInteiroComum("1 real");
            Console.WriteLine(new string('-', 40));

            ValidarNumeroInteiroOutVariable("1");
            ValidarNumeroInteiroOutVariable("1 real");
            Console.WriteLine(new string('-', 40));

            ValidarNumeroInteiroOutVariableDiscard("1");
            ValidarNumeroInteiroOutVariableDiscard("1 real");
            Console.WriteLine(new string('-', 40));

            Console.ReadKey();
        }

        private static void ValidarNumeroInteiroComum(string valor)
        {
            int numero = 0;

            if (int.TryParse(valor, out numero))
                Console.WriteLine($"A Entrada '{valor}' é um número inteiro válido");
            else
                Console.WriteLine($"A Entrada '{valor}' NÃO é um número inteiro válido");
        }

        private static void ValidarNumeroInteiroOutVariable(string valor)
        {
            if (int.TryParse(valor, out int numero))
                Console.WriteLine($"A Entrada '{valor}' é um número inteiro válido");
            else
                Console.WriteLine($"A Entrada '{valor}' NÃO é um número inteiro válido");
        }

        private static void ValidarNumeroInteiroOutVariableDiscard(string valor)
        {
            if (int.TryParse(valor, out _))
                Console.WriteLine($"A Entrada '{valor}' é um número inteiro válido");
            else
                Console.WriteLine($"A Entrada '{valor}' NÃO é um número inteiro válido");
        }
    }
}
