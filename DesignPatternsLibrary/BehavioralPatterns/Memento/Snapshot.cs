namespace DesignPatterns.BehavioralPatterns.Memento
{
    /// <summary>
    // A classe memento armazena o estado anterior do editor.
    // Faz o papel do Caretaker
    /// </summary>
    public class Snapshot
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;
        private Editor Editor { get; set; }
        private string Text { get; set; }

        public Snapshot(Editor editor, string text)
        {
            Editor = editor;
            Text = text;
        }

        public void Restore()
        {
            Output.EscreverTexto($"Restaurando texto: {Text}");
            Editor.SetText(Text);
        }
    }
}