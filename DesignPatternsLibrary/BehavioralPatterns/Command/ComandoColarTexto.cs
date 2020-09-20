namespace DesignPatterns.BehavioralPatterns.Command
{
    // Comandos concretos
    public class ComandoColarTexto : ICommand
    {
        private readonly ISaidaDeTexto _saidaDeTexto;
        public readonly EditorTexto _editorTexto;

        public ComandoColarTexto(EditorTexto editorTexto, ISaidaDeTexto saidaDeTexto)
        {
            _editorTexto = editorTexto;
            _saidaDeTexto = saidaDeTexto;
        }

        public void Execute()
        {
            string texto = Memoria.RetornaTextoEmMemoria();
            _saidaDeTexto.EscreverTexto($"Texto colado pelo comando!\t{nameof(ComandoColarTexto)}.{nameof(Execute)}");
            _editorTexto.ColarNoEditor(texto);
        }
    }
}