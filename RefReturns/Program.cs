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

            ref DateTime data = ref ObterDataAtualRefReturn();
            data = data.AddYears(20);
            Console.WriteLine($"Data Atual: {ObterDataAtual()}");

            Console.ReadKey();
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
