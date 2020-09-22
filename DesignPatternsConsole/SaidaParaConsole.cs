using System;

namespace DesignPatterns
{
    public class SaidaParaConsole : ISaidaDeTexto
    {
        public void AguardaUmaTecla()
        {
            Console.ReadKey();
        }

        public void EscreverTexto(string mensagem)
        {
            Console.WriteLine(mensagem);
        }

        public void Limpar()
        {
            Console.Clear();
        }
    }
}