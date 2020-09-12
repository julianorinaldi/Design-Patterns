namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class Carro
    {
        private readonly TipoCarroEnum _tipoCarro;

        public Carro(TipoCarroEnum tipoCarro)
        {
            _tipoCarro = tipoCarro;
        }

        public TipoCarroEnum TipoCarro => _tipoCarro;
        public Roda Roda { get; set; }
        public Som Som { get; set; }
    }
}