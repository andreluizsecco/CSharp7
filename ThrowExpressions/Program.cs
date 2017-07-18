using System;

namespace ThrowExpressions
{
    class Program
    {
        private static double _nota;

        static void Main(string[] args)
        {
            //LancarNotaComum(11);
            LancarNotaCSharp7(11);
        }

        private static void LancarNotaComum(double nota)
        {
            if (nota >= 0 && nota <= 10)
                _nota = nota;
            else
                throw new Exception("Nota inválida!");
        }
        private static void LancarNotaCSharp7(double nota)
        {
            _nota = (nota >= 0 && nota <= 10)? nota : throw new Exception("Nota inválida!");
        }
    }
}
