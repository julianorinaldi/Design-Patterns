namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public class TradutorParaEspanhol : Tradutor
    {
        public TradutorParaEspanhol(ITranslator translator, ISaidaDeTexto saidaDeTexto)
            : base(translator, saidaDeTexto)
        {
        }

        protected override string Traduzir(string inputText)
        {
            // Aqui faria a análise se este texto é espanhol
            // Talvez procurar em um dicionário as palavras, etc.
            SaidaDeTexto.EscreverTexto($"Detectando se o idioma é {this.GetType()}");
            string targetLanguage = "es";

            return Translator.Traduzir(inputText, targetLanguage);
        }
    }
}