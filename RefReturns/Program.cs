using System;

namespace RefReturns
{
    class Program
    {
        private static DateTime _dataAtual;

        static void Main(string[] args)
        {
            _dataAtual = DateTime.Now;

            Console.WriteLine($"Data Atual: {ObterDataAtual()}");
            Console.WriteLine(new string('-', 40));

            //Convencional
            AlterarDataAtual(ref _dataAtual);
            Console.WriteLine($"Data Atual: {_dataAtual}");
            Console.WriteLine(new string('-', 40));

            //C# 7 - Ref Returns
            ref DateTime data = ref ObterDataAtualRefReturn();
            data = data.AddYears(20);
            Console.WriteLine($"Data Atual: {ObterDataAtual()}");

            Console.ReadKey();
        }

        private static void AlterarDataAtual(ref DateTime data)
        {
            data = data.AddYears(5);
        }

        private static DateTime ObterDataAtual()
        {
            return _dataAtual;
        }

        private static ref DateTime ObterDataAtualRefReturn()
        {
            return ref _dataAtual;
        }
    }
}
