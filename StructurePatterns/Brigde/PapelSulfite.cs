namespace DesignPatterns.StructurePatterns.Brigde
{
    public class PapelSulfite : IPapel
    {
        public string Nome => nameof(PapelSulfite);

        public int Gramatura => 75;
    }
}