namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Chuteira : ITenisBuilder
    {
        private readonly Tenis _tenis;

        public Chuteira(string nome)
        {
            _tenis = new Tenis(nome);
        }

        public Tenis Builder()
        {
            return _tenis;
        }

        public ITenisBuilder BuilderCadarco()
        {
            _tenis.Cadarco = new Cadarco("Preto/Nylon");
            return this;
        }

        public ITenisBuilder BuilderCostura()
        {
            _tenis.Costura = new Costura("Trançado");
            return this;
        }

        public ITenisBuilder BuilderEstrutura()
        {
            _tenis.Estrutura = new Estrutura("Couro");
            return this;
        }

        public ITenisBuilder BuilderPalmilha()
        {
            _tenis.Palmilha = new Plamilha("EVA");
            return this;
        }

        public ITenisBuilder BuilderSola()
        {
            _tenis.Sola = new Sola("Travas de alumínio");
            return this;
        }
    }
}