namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Cadarco
    {
        public string TipoCadarco { get; private set; }

        public Cadarco(string tipoCadarco)
        {
            TipoCadarco = tipoCadarco;
        }
    }
}