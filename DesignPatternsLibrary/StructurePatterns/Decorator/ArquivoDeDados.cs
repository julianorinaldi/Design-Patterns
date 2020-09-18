namespace DesignPatterns.StructurePatterns.Decorator
{
    public class ArquivoDeDados : IDados
    {
        public string ConteudoDoArquivo { get; private set; }

        public ArquivoDeDados(string conteudoDoArquivo)
        {
            ConteudoDoArquivo = conteudoDoArquivo;
        }

        public void EscreverDados(string text)
        {
            ConteudoDoArquivo = text;
        }

        public string LerDados()
        {
            return ConteudoDoArquivo;
        }
    }
}