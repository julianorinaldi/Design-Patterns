namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Estrutura
    {
        public string MaterialEstrutura { get; private set; }

        public Estrutura(string materialEstrutura)
        {
            MaterialEstrutura = materialEstrutura;
        }
    }
}