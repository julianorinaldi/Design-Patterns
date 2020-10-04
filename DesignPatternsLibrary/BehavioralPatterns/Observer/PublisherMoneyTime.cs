using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    public class PublisherMoneyTime
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;
        private ConcurrentBag<ISubscriberMoney> _subscribers = new ConcurrentBag<ISubscriberMoney>();
        private decimal _moneyInTime;

        public void Subscribe(ISubscriberMoney subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                Output.EscreverTexto($"Mais um caboclo inscrito, nome: {subscriber.ToString()}");
                _subscribers.Add(subscriber);
            }
        }

        public void Unsubscribe(ISubscriberMoney subscriber)
        {
            _subscribers.TryTake(out subscriber);
            if (subscriber != null)
                Output.EscreverTexto($"Caboclo removeu inscrição, nome: {subscriber.ToString()}");
        }

        protected void NotifySubscribers()
        {
            Output.EscreverTexto($"Notificando o povo da mudança do dinheiro");
            foreach (var item in _subscribers)
            {
                item.UpdateMoney(_moneyInTime);
            }
        }

        public void ControlMoneyTimeStart()
        {
            Random random = new Random();
            int count = 0;
            while (true)
            {
                Thread.Sleep(5000);
                count++;
                var rNum = random.NextDouble();
                _moneyInTime = Convert.ToDecimal(rNum * 10);
                NotifySubscribers();

                if (count >= 6)
                    return;
            }
        }
    }
}