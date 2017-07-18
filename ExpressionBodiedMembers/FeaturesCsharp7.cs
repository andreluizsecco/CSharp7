namespace ExpressionBodiedMembers
{
    class FeaturesCsharp7
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        private double _valor;

        // Utilização na definição de propriedade pelo get e set (C# 7)
        public double Valor
        {
            get => _valor;
            set => _valor = value >= 0 ? value : 0;
        }

        //Construtor
        public FeaturesCsharp7() => ValorUnitario = 10;

        //Finalizer
        ~FeaturesCsharp7() => ValorUnitario = 0;
    }
}
