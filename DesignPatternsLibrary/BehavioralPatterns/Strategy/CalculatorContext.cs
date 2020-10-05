namespace DesignPatterns.BehavioralPatterns.Strategy
{
    public class CalculatorContext
    {
        private ICalculateStrategy _calculateStrategy;

        public void SetStrategy(ICalculateStrategy calculateStrategy)
        {
            _calculateStrategy = calculateStrategy;
        }

        public decimal Calculate(decimal a, decimal b)
        {
            if (_calculateStrategy != null)
                return _calculateStrategy.Calculate(a, b);

            return 0;
        }
    }
}