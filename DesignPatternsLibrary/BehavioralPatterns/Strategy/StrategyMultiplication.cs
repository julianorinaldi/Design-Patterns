namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public class StrategyMultiplication : ICalculateStrategy
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public decimal Calculate(decimal num1, decimal num2)
        {
            Output.EscreverTexto($"Multiplicação: {num1} * {num2}");
            return num1 * num2;
        }
    }
}