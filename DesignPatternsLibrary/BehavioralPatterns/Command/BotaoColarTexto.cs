using System;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class BotaoColarTexto : IEventClick
    {
        private readonly Invoker _Invoker = new Invoker();

        public BotaoColarTexto(EditorTexto editorTexto)
        {
            _Invoker.SetCommand(new ComandoColarTexto(editorTexto));
        }

        public void OnClick(object sender, EventArgs e)
        {
            _Invoker.ExecuteCommand();
        }
    }
}