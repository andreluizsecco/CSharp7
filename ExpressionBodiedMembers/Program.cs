using System;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Features C# 6.0
            Console.WriteLine("Features no C# 6.0");
            var cSharp6 = new FeaturesCSharp6();
            Console.WriteLine($"Total via propriedade: {cSharp6.ValorTotal}");
            Console.WriteLine($"Total via método: {cSharp6.CalcularValorTotal()}");
            Console.WriteLine(new string('-', 40));

            Console.ReadKey();

            // Features C# 7.0
            new FeaturesCsharp7();
        }
    }
}
