namespace DesignPatterns.BehavioralPatterns.Command
{
    // Comandos concretos
    public class ComandoCopiarTexto : ICommand
    {
        public readonly EditorTexto _editorTexto;

        public ComandoCopiarTexto(EditorTexto editorTexto)
        {
            _editorTexto = editorTexto;
        }

        public void Execute()
        {
            _editorTexto.SelecionarTexto();
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Texto copiado pelo comando!\t{nameof(ComandoCopiarTexto)}.{nameof(Execute)}");
        }
    }
}