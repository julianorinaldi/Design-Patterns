namespace DesignPatterns.BehavioralPatterns.Command
{
    // Comandos concretos
    public class ComandoCopiarTexto : ICommand
    {
        private readonly ISaidaDeTexto _saidaDeTexto;
        public readonly EditorTexto _editorTexto;

        public ComandoCopiarTexto(EditorTexto editorTexto, ISaidaDeTexto saidaDeTexto)
        {
            _editorTexto = editorTexto;
            _saidaDeTexto = saidaDeTexto;
        }

        public void Execute()
        {
            _editorTexto.SelecionarTexto();
            _saidaDeTexto.EscreverTexto($"Texto copiado pelo comando!\t{nameof(ComandoCopiarTexto)}.{nameof(Execute)}");
        }
    }
}