using System;

namespace DesignPatterns
{
    public class SaidaParaConsole : ISaidaDeTexto
    {
        public void EscreverTexto(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void EscreverTexto()
        {
            Console.WriteLine();
        }
    }
}