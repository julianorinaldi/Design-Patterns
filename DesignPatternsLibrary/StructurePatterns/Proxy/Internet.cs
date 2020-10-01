namespace DesignPatterns.StructurePatterns.Proxy
{
    internal class Internet : IConsomeInternet
    {
        public Internet()
        {
        }

        public void Navegar(string url)
        {
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Permitida a navegação na internet para a URL {url}!.");
        }
    }
}