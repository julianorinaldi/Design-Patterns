using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        protected ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public void Visit(Computer computer)
        {
            Output.EscreverTexto("Mostrando computador!");
        }

        public void Visit(Mouse mouse)
        {
            Output.EscreverTexto("Mostrando mouse!");
        }

        public void Visit(Keyboard keyboard)
        {
            Output.EscreverTexto("Mostrando teclado!");
        }

        public void Visit(Monitor monitor)
        {
            Output.EscreverTexto("Mostrando monitor!");
        }
    }
}