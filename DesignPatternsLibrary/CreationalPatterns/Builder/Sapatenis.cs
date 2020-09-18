namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Sapatenis : ITenisBuilder
    {
        private readonly Tenis _tenis;

        public Sapatenis(string nome)
        {
            _tenis = new Tenis(nome);
        }

        public Tenis Builder()
        {
            return _tenis;
        }

        public ITenisBuilder BuilderCadarco()
        {
            _tenis.Cadarco = new Cadarco("Sem Cadarço");
            return this;
        }

        public ITenisBuilder BuilderCostura()
        {
            _tenis.Costura = new Costura("Zig Zag");
            return this;
        }

        public ITenisBuilder BuilderEstrutura()
        {
            _tenis.Estrutura = new Estrutura("Couro");
            return this;
        }

        public ITenisBuilder BuilderPalmilha()
        {
            _tenis.Palmilha = new Plamilha("Anti Chulé");
            return this;
        }

        public ITenisBuilder BuilderSola()
        {
            _tenis.Sola = new Sola("Emborrachada");
            return this;
        }
    }
}