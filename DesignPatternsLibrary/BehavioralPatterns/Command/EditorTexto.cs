namespace DesignPatterns.BehavioralPatterns.Command
{
    public class EditorTexto
    {
        public EditorTexto()
        {
        }

        public void SelecionarTexto()
        {
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Texto Selecionado!\t{nameof(EditorTexto)}.{nameof(SelecionarTexto)}");
        }

        public void ColarNoEditor(string texto)
        {
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Texto Colado! [{texto}]\t{nameof(EditorTexto)}.{nameof(ColarNoEditor)}");
        }
    }
}