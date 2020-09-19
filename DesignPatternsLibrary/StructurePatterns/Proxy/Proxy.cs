namespace DesignPatterns.StructurePatterns.Proxy
{
    public class Proxy : IConsomeInternet
    {
        private readonly ISaidaDeTexto _saidaDeTexto;
        private readonly Internet _internet;

        public Proxy(ISaidaDeTexto saidaDeTexto)
        {
            _saidaDeTexto = saidaDeTexto;
            _internet = new Internet(saidaDeTexto);
        }

        public void Navegar(string url)
        {
            GerenciadorSites gerenciadorSites = new GerenciadorSites();
            if (gerenciadorSites.SiteEstaLiberado(url))
                _internet.Navegar(url);
            else
                _saidaDeTexto.EscreverTexto($"Não foi permitida a navegação na internet para a URL {url}!");
        }
    }
}