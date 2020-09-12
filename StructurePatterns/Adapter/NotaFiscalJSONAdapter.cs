namespace DesignPatterns.StructurePatterns.Adapter
{
    public class NotaFiscalJSONAdapter : NotaFiscalXML
    {
        private readonly NotaFiscalXML _notaFiscalXML;

        public NotaFiscalJSONAdapter(NotaFiscalXML notaFiscalXML) : base(notaFiscalXML.NumeroNota)
        {
            _notaFiscalXML = notaFiscalXML;
        }

        public override string GerarNotaFiscal()
        {
            return @$"xml {{ numeroNota: {_notaFiscalXML.NumeroNota} }}";
        }
    }
}