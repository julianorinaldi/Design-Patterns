namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public class TradutorParaIngles : Tradutor
    {
        public TradutorParaIngles(ITranslator translator, ISaidaDeTexto saidaDeTexto)
            : base(translator, saidaDeTexto)
        {
        }

        protected override string Traduzir(string inputText)
        {
            // Aqui faria a análise se este texto é inglês
            // Talvez procurar em um dicionário as palavras, etc.
            SaidaDeTexto.EscreverTexto($"Detectando se o idioma é {this.GetType()}");
            string targetLanguage = "en";

            return Translator.Traduzir(inputText, targetLanguage);
        }
    }
}