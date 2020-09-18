namespace DesignPatterns.CreationalPatterns.Builder
{
    public interface ITenisBuilder
    {
        public Tenis Builder();

        public ITenisBuilder BuilderSola();

        public ITenisBuilder BuilderEstrutura();

        public ITenisBuilder BuilderCostura();

        public ITenisBuilder BuilderPalmilha();

        public ITenisBuilder BuilderCadarco();
    }
}