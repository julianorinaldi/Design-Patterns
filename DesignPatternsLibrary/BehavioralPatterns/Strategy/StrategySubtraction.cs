namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public class StrategySubtraction : ICalculateStrategy
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public decimal Calculate(decimal num1, decimal num2)
        {
            Output.EscreverTexto($"Subtração: {num1} - {num2}");
            return num1 - num2;
        }
    }
}