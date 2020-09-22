using System;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class AtalhoCopiarTexto : IEventClick
    {
        private readonly Invoker _Invoker = new Invoker();

        public AtalhoCopiarTexto(EditorTexto editorTexto)
        {
            _Invoker.SetCommand(new ComandoCopiarTexto(editorTexto));
        }

        public void OnClick(object sender, EventArgs e)
        {
            _Invoker.ExecuteCommand();
        }
    }
}