﻿using System;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class AtalhoColarTexto : IEventClick
    {
        private readonly Invoker _Invoker = new Invoker();

        public AtalhoColarTexto(EditorTexto editorTexto, ISaidaDeTexto saidaDeTexto)
        {
            _Invoker.SetCommand(new ComandoColarTexto(editorTexto, saidaDeTexto));
        }

        public void OnClick(object sender, EventArgs e)
        {
            _Invoker.ExecuteCommand();
        }
    }
}