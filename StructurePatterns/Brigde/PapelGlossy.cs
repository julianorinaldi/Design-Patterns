namespace DesignPatterns.StructurePatterns.Brigde
{
    public class PapelGlossy : IPapel
    {
        public string Nome => nameof(PapelGlossy);

        public int Gramatura => 120;
    }
}