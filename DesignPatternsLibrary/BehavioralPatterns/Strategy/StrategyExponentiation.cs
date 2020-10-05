using System;

namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public class StrategyExponentiation : ICalculateStrategy
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public decimal Calculate(decimal num1, decimal num2)
        {
            Output.EscreverTexto($"Exponenciação: {num1} ^ {num2}");
            return (decimal)Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2));
        }
    }
}