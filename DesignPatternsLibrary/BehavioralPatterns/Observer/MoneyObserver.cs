namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class MoneyObserver : ISubscriberMoney
    {
        private string _nameObserver;
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public MoneyObserver(string nameObserver)
        {
            _nameObserver = nameObserver;
        }

        public void UpdateMoney(decimal moneyInTime)
        {
            Output.EscreverTexto($"Observador {_nameObserver} agora sabe que o dinheiro está em: {moneyInTime}");
        }

        public override string ToString()
        {
            return _nameObserver;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}