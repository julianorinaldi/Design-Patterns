﻿namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public class TradutorParaEspanhol : Tradutor
    {
        public TradutorParaEspanhol(ITranslator translator)
            : base(translator)
        {
        }

        protected override string Traduzir(string inputText)
        {
            // Aqui faria a análise se este texto é espanhol
            // Talvez procurar em um dicionário as palavras, etc.
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Detectando se o idioma é {this.GetType()}");
            string targetLanguage = "es";

            return Translator.Traduzir(inputText, targetLanguage);
        }
    }
}