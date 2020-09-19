namespace DesignPatterns.StructurePatterns.Proxy
{
    internal class Internet : IConsomeInternet
    {
        public ISaidaDeTexto SaidaDeTexto { get; }

        public Internet(ISaidaDeTexto saidaDeTexto)
        {
            SaidaDeTexto = saidaDeTexto;
        }

        public void Navegar(string url)
        {
            SaidaDeTexto.EscreverTexto($"Permitida a navegação na internet para a URL {url}!.");
        }
    }
}