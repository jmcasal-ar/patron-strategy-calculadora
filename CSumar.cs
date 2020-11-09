using System;

namespace calculadora_strategy_pattern
{
    public class CSumar : IOperacion
    {
        
        public double Calcular(double a, double b)
        {
            return a+b;
        }
    }
}