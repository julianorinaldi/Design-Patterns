namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public abstract class FiscalizadorBagagem
    {
        protected FiscalizadorBagagem ProximoFiscalizador { get; set; }

        public void RegistrarFiscalizador(FiscalizadorBagagem fiscalizador)
        {
            ProximoFiscalizador = fiscalizador;
        }

        public abstract void FiscalizarBagagem(Bagagem bagagem);
    }
}