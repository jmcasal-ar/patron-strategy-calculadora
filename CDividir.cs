namespace calculadora_strategy_pattern
{
    public class CDividir : IOperacion
    {
        public double Calcular(double a, double b)
        {
            return a/b;
        }
    }
}