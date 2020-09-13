using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructurePatterns.Composite
{
    /// <summary>
    /// Faz o papel do Component
    /// </summary>
    public interface IEstruturaDaArvore
    {
        public void Criar(ISaidaDeTexto saidaDeTexto);
    }
}