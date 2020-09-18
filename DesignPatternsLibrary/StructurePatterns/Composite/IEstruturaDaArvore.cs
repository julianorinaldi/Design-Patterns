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