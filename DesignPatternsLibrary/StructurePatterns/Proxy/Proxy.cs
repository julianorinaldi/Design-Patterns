using DesignPatternsConsole;

namespace DesignPatterns.StructurePatterns.Proxy
{
    public class Proxy : IConsomeInternet
    {
        private readonly Internet _internet;

        public Proxy()
        {
            _internet = new Internet();
        }

        public void Navegar(string url)
        {
            GerenciadorSites gerenciadorSites = new GerenciadorSites();
            if (gerenciadorSites.SiteEstaLiberado(url))
                _internet.Navegar(url);
            else
                GerenciadorSaida.SaidaConsole.EscreverTexto($"Não foi permitida a navegação na internet para a URL {url}!");
        }
    }
}