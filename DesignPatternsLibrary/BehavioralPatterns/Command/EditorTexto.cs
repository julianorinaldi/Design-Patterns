namespace DesignPatterns.BehavioralPatterns.Command
{
    public class EditorTexto
    {
        private readonly ISaidaDeTexto _saidaDeTexto;

        public EditorTexto(ISaidaDeTexto saidaDeTexto)
        {
            _saidaDeTexto = saidaDeTexto;
        }

        public void SelecionarTexto()
        {
            _saidaDeTexto.EscreverTexto($"Texto Selecionado!\t{nameof(EditorTexto)}.{nameof(SelecionarTexto)}");
        }

        public void ColarNoEditor(string texto)
        {
            _saidaDeTexto.EscreverTexto($"Texto Colado! [{texto}]\t{nameof(EditorTexto)}.{nameof(ColarNoEditor)}");
        }
    }
}