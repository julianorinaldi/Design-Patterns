namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Costura
    {
        public string TipoCostura { get; private set; }

        public Costura(string tipoCostura)
        {
            TipoCostura = tipoCostura;
        }
    }
}