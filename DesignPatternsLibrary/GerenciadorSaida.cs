using DesignPatterns;

namespace DesignPatternsConsole
{
    public class GerenciadorSaida
    {
        private static ISaidaDeTexto _saidaDeTexto;
        private static IGraphicConsole _graphicConsole;

        public GerenciadorSaida(ISaidaDeTexto saidaDeTexto,
                                IGraphicConsole graphicConsole)
        {
            _saidaDeTexto = saidaDeTexto;
            _graphicConsole = graphicConsole;
        }

        private static void VerificaInstancia()
        {
            if (_saidaDeTexto == null)
                throw new System.Exception($"{nameof(ISaidaDeTexto)} não tem instância.");
            if (_graphicConsole == null)
                throw new System.Exception($"{nameof(IGraphicConsole)} não tem instância.");
        }

        public static ISaidaDeTexto SaidaConsole
        {
            get
            {
                VerificaInstancia();
                return _saidaDeTexto;
            }
        }

        public static IGraphicConsole TelaGraficaConsole
        {
            get
            {
                VerificaInstancia();
                return _graphicConsole;
            }
        }
    }
}