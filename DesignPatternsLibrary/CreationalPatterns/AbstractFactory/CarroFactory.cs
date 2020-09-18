namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public abstract class CarroFactory
    {
        public abstract TipoCarroEnum TipoCarro { get; }

        public abstract Roda MontarRoda();

        public abstract Som MontarSom();
    }
}