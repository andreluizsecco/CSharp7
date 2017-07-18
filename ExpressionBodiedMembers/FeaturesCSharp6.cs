namespace ExpressionBodiedMembers
{
    class FeaturesCSharp6
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal => ValorUnitario * Quantidade; // Expression-bodied Properties no C# 6.0 (read-only)

        public double CalcularValorTotal() => ValorTotal; // Expression-bodied Functions no C# 6.0

        public FeaturesCSharp6()
        {
            ValorUnitario = 10;
            Quantidade = 2;
        }
    }
}
