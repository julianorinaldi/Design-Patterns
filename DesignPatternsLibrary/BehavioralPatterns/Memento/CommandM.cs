namespace DesignPatterns.BehavioralPatterns.Memento
{
    /// <summary>
    // Um objeto comando pode agir como cuidador. Neste caso, o
    // comando obtém o memento antes que ele mude o estado do
    // originador. Quando o undo(desfazer) é solicitado, ele
    // restaura o estado do originador a partir de um memento.
    /// </summary>
    public class CommandM
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;
        private Snapshot BackupEditor { get; set; }

        public void MakeBackup(Snapshot snapshot)
        {
            BackupEditor = snapshot;
        }

        public void Undo()
        {
            if (BackupEditor != null)
            {
                Output.EscreverTexto("Executando Undo");
                BackupEditor.Restore();
            }
        }
    }
}