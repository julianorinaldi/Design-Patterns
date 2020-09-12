namespace DesignPatterns.StructurePatterns.Adapter
{
    public class NotaFiscalXML
    {
        public string NumeroNota { get; private set; }

        public NotaFiscalXML(string numeroNota)
        {
            NumeroNota = numeroNota;
        }

        public virtual string GerarNotaFiscal()
        {
            return @$"<xml><numeroNota>{NumeroNota}</numeroNota></xml>";
        }
    }
}