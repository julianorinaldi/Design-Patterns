namespace DesignPatterns.BehavioralPatterns.Memento
{
    /// <summary>
    // O originador tem alguns dados importantes que podem mudar com
    // o tempo. Ele também define um método para salvar seu estado
    // dentro de um memento e outro método para restaurar o estado
    // dele.
    /// </summary>
    public class Editor
    {
        private string Text { get; set; }
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public Editor()
        {
        }

        public void SetText(string text)
        {
            Output.EscreverTexto($"Escrevendo texto: {text}");
            Text = text;
        }

        public Snapshot CreateSnapshot()
        {
            Output.EscreverTexto("Criando um Snapshot");
            return new Snapshot(this, Text);
        }
    }
}