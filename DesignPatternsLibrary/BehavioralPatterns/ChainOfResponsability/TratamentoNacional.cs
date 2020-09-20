namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public class TratamentoNacional : FiscalizadorBagagem
    {
        public TratamentoNacional(ISaidaDeTexto saidaDeTexto) : base(saidaDeTexto)
        {
        }

        public override void FiscalizarBagagem(Bagagem bagagem)
        {
            if (bagagem.OrigemViagem == Origem.NACIONAL)
            {
                SaidaDeTexto.EscreverTexto($"{bagagem.OrigemViagem} - Bagagem do proprietário {bagagem.Proprietario} não terá fiscalização.");
            }
            else if (ProximoFiscalizador != null)
            {
                ProximoFiscalizador.FiscalizarBagagem(bagagem);
            }
        }
    }
}