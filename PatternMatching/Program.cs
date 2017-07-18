using System;
using static PatternMatching.CotacaoMonetaria;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            CotacaoDolar dolar = new CotacaoDolar();
            dolar.DataCotacao = new DateTime(2017, 7, 17);
            dolar.ValorComercial = 3.1814;
            dolar.ValorTurismo = 3.31;
            ExibirInformacoesCotacao(dolar);
            DecisaoViagem(dolar);

            CotacaoEuro euro = new CotacaoEuro();
            euro.DataCotacao = new DateTime(2017, 7, 17);
            euro.ValorCotacao = 3.6538;
            ExibirInformacoesCotacao(euro);
            DecisaoViagem(euro);

            CotacaoBitcoin bitcoin = new CotacaoBitcoin();
            bitcoin.DataCotacao = new DateTime(2017, 7, 17);
            bitcoin.ValorCotacaoMecadoBitcoin = 7488.99;
            ExibirInformacoesCotacao(bitcoin);

            Console.ReadKey();
        }

        //public static void ExibirInformacoesCotacao(Cotacao cotacao)
        //{
        //    double valorCotacao = 0;
        //    if (cotacao is CotacaoDolar)
        //    {
        //        valorCotacao =
        //            ((CotacaoDolar)cotacao).ValorComercial;
        //    }
        //    else if (cotacao is CotacaoEuro)
        //    {
        //        valorCotacao =
        //            ((CotacaoEuro)cotacao).ValorCotacao;
        //    }
        //    else if (cotacao is CotacaoBitcoin)
        //    {
        //        valorCotacao =
        //            ((CotacaoBitcoin)cotacao).ValorCotacaoMecadoBitcoin;
        //    }

        //    Console.WriteLine(new String('-', 40));
        //    Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
        //    Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
        //    Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
        //    Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        //}

        //public static void ExibirInformacoesCotacao(Cotacao cotacao)
        //{
        //    double valorCotacao = 0;
        //    if (cotacao is CotacaoDolar dolar)
        //        valorCotacao = dolar.ValorComercial;
        //    else if (cotacao is CotacaoEuro euro)
        //        valorCotacao = euro.ValorCotacao;
        //    else if (cotacao is CotacaoBitcoin bitcoin)
        //        valorCotacao = bitcoin.ValorCotacaoMecadoBitcoin;

        //    Console.WriteLine(new String('-', 40));
        //    Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
        //    Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
        //    Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
        //    Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        //}

        private static void ExibirInformacoesCotacao(Cotacao cotacao)
        {
            double valorCotacao;
            switch (cotacao)
            {
                case CotacaoDolar dolar:
                    valorCotacao = dolar.ValorComercial;
                    break;
                case CotacaoEuro euro:
                    valorCotacao = euro.ValorCotacao;
                    break;
                case CotacaoBitcoin bitcoin:
                    valorCotacao = bitcoin.ValorCotacaoMecadoBitcoin;
                    break;
                default:
                    valorCotacao = 0;
                    break;
            }

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
            Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
            Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
            Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        }

        private static void DecisaoViagem(Cotacao cotacao)
        {
            switch (cotacao)
            {
                case CotacaoDolar dolar when (dolar.ValorTurismo <= 3.4):
                    Console.WriteLine("Hora de viajar para o EUA!");
                    break;
                case CotacaoDolar dolar when (dolar.ValorTurismo > 3.4):
                    Console.WriteLine("Melhor ficar em casa!");
                    break;
                case CotacaoEuro euro when (euro.ValorCotacao <= 3.2):
                    Console.WriteLine("Hora de viajar para Europa!");
                    break;
                case CotacaoEuro euro when (euro.ValorCotacao > 3.2):
                    Console.WriteLine("Melhor ficar em casa!");
                    break;
            }
        }
    }
}
