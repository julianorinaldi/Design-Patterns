using DesignPatternsConsole;

namespace DesignPatterns.BehavioralPatterns.Command
{
    // Comandos concretos
    public class ComandoColarTexto : ICommand
    {
        public readonly EditorTexto _editorTexto;

        public ComandoColarTexto(EditorTexto editorTexto)
        {
            _editorTexto = editorTexto;
        }

        public void Execute()
        {
            string texto = Memoria.RetornaTextoEmMemoria();
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Texto colado pelo comando!\t{nameof(ComandoColarTexto)}.{nameof(Execute)}");
            _editorTexto.ColarNoEditor(texto);
        }
    }
}