namespace DesignPatterns.StructurePatterns.Brigde
{
    public class PapelVegetal : IPapel
    {
        public string Nome => nameof(PapelVegetal);

        public int Gramatura => 180;
    }
}