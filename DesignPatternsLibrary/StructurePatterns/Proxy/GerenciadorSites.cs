using System.Collections.Generic;

namespace DesignPatterns.StructurePatterns.Proxy
{
    internal class GerenciadorSites
    {
        private List<string> _sitesLiberados = new List<string>();
        public string[] SitesLiberados { get { return _sitesLiberados.ToArray(); } }

        public GerenciadorSites()
        {
            _sitesLiberados.Add("www.microsoft.com");
            _sitesLiberados.Add("www.github.com");
        }

        public bool SiteEstaLiberado(string url)
        {
            return _sitesLiberados.Contains(url);
        }
    }
}