namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public abstract class Tradutor
    {
        protected ISaidaDeTexto SaidaDeTexto { get; }

        protected ITranslator Translator { get; }

        protected abstract string Traduzir(string inputText);

        public Tradutor(ITranslator translator, ISaidaDeTexto saidaDeTexto)
        {
            Translator = translator;
            SaidaDeTexto = saidaDeTexto;
        }

        public void Interpretador(Contexto contexto)
        {
            contexto.Traduzido = Traduzir(contexto.EntradaTexto);
        }
    }
}