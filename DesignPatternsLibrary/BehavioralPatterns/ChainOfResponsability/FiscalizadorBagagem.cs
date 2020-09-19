namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public abstract class FiscalizadorBagagem
    {
        protected FiscalizadorBagagem ProximoFiscalizador { get; set; }

        protected ISaidaDeTexto SaidaDeTexto { get; }

        public FiscalizadorBagagem(ISaidaDeTexto saidaDeTexto)
        {
            SaidaDeTexto = saidaDeTexto;
        }

        public void RegistrarFiscalizador(FiscalizadorBagagem fiscalizador)
        {
            ProximoFiscalizador = fiscalizador;
        }

        public abstract void FiscalizarBagagem(Bagagem bagagem);
    }
}