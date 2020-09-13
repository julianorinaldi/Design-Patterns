using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructurePatterns.Composite
{
    /// <summary>
    /// Faz o papel do Leaf/Folha
    /// </summary>
    public class Folha : IEstruturaDaArvore
    {
        private string _nomeFolha;

        public Folha(string nomeFolha)
        {
            _nomeFolha = nomeFolha;
        }

        public void Criar(ISaidaDeTexto saidaDeTexto)
        {
            saidaDeTexto?.EscreverTexto(_nomeFolha);
        }
    }
}