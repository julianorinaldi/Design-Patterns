using System.Collections.Generic;

namespace DesignPatterns.StructurePatterns.Composite
{
    /// <summary>
    /// Faz o papel de Composite
    /// </summary>
    public class Arvore : IEstruturaDaArvore
    {
        public List<IEstruturaDaArvore> _estrutura = new List<IEstruturaDaArvore>();
        private string _nomeArvore;

        public Arvore(string nomeArvore)
        {
            _nomeArvore = nomeArvore;
        }

        public Arvore AdicionarItem(IEstruturaDaArvore estrutura)
        {
            _estrutura.Add(estrutura);
            return this;
        }

        public Arvore RemoverItem(IEstruturaDaArvore estrutura)
        {
            _estrutura.Remove(estrutura);

            return this;
        }

        public void Criar(ISaidaDeTexto saidaDeTexto)
        {
            saidaDeTexto?.EscreverTexto(_nomeArvore);

            foreach (var estrutura in _estrutura)
            {
                estrutura.Criar(saidaDeTexto);
            }
        }
    }
}