using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class SaidaParaConsole : ISaidaDeTexto
    {
        public void EscreverTexto(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}