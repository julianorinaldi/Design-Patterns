namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public interface ITranslator
    {
        public string Traduzir(string message, string targetLanguage);
    }
}