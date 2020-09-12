namespace DesignPatterns.StructurePatterns.Brigde
{
    public class PapelReciclado : IPapel
    {
        public string Nome => nameof(PapelReciclado);

        public int Gramatura => 90;
    }
}