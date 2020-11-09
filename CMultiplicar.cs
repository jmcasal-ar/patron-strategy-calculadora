using calculadora_strategy_pattern;
namespace calculadora_strategy_pattern

{
    public class CMultiplicar : IOperacion
    {
        public double Calcular(double a, double b)
        {
            return a*b;
        }
    }
}