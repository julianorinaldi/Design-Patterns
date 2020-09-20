using System;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class BotaoCopiarTexto : IEventClick
    {
        private readonly Invoker _Invoker = new Invoker();

        public BotaoCopiarTexto(EditorTexto editorTexto, ISaidaDeTexto saidaDeTexto)
        {
            _Invoker.SetCommand(new ComandoCopiarTexto(editorTexto, saidaDeTexto));
        }

        public void OnClick(object sender, EventArgs e)
        {
            _Invoker.ExecuteCommand();
        }
    }
}