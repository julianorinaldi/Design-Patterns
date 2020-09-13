namespace DesignPatterns.StructurePatterns.Decorator
{
    public abstract class DadosDecorator : IDados
    {
        protected IDados Dados { get; }

        public DadosDecorator(IDados dados)
        {
            Dados = dados;
        }

        public virtual void EscreverDados(string text)
        {
            Dados.EscreverDados(text);
        }

        public virtual string LerDados()
        {
            return Dados.LerDados();
        }
    }
}