namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public class TratamentoInternacional : FiscalizadorBagagem
    {
        public TratamentoInternacional(ISaidaDeTexto saidaDeTexto) : base(saidaDeTexto)
        {
        }

        public override void FiscalizarBagagem(Bagagem bagagem)
        {
            if (bagagem.OrigemViagem == Origem.INTERNACIONAL)
            {
                bool aprovaEnteda = ReceitaFederal.AprovaEntradaBagagem(bagagem);
                SaidaDeTexto.EscreverTexto($"{bagagem.OrigemViagem} - Bagagem do proprietário {bagagem.Proprietario} {(aprovaEnteda == false ? "não está" : "está")} aprovada.");
            }
            else if (ProximoFiscalizador != null)
            {
                ProximoFiscalizador.FiscalizarBagagem(bagagem);
            }
        }
    }
}