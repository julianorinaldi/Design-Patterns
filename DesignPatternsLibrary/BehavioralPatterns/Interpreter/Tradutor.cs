namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public abstract class Tradutor
    {
        protected ITranslator Translator { get; }

        protected abstract string Traduzir(string inputText);

        public Tradutor(ITranslator translator)
        {
            Translator = translator;
        }

        public void Interpretador(Contexto contexto)
        {
            contexto.Traduzido = Traduzir(contexto.EntradaTexto);
        }
    }
}