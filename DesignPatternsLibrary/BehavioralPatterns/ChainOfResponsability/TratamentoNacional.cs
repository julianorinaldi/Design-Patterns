using DesignPatternsConsole;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public class TratamentoNacional : FiscalizadorBagagem
    {
        public TratamentoNacional() : base()
        {
        }

        public override void FiscalizarBagagem(Bagagem bagagem)
        {
            if (bagagem.OrigemViagem == Origem.NACIONAL)
            {
                GerenciadorSaida.SaidaConsole.EscreverTexto($"{bagagem.OrigemViagem} - Bagagem do proprietário {bagagem.Proprietario} não terá fiscalização.");
            }
            else if (ProximoFiscalizador != null)
            {
                ProximoFiscalizador.FiscalizarBagagem(bagagem);
            }
        }
    }
}