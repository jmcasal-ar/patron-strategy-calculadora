namespace calculadora_strategy_pattern
{
    public class CRestar : IOperacion
    {
        public double Calcular(double a, double b)
        {
            return a-b;
        }
    }
}