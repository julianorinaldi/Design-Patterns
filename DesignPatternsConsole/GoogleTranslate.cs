using DesignPatterns.BehavioralPatterns.Interpreter;
using OpenQA.Selenium;
using System;
using System.Web;

namespace DesignPatternsConsole
{
    public class GoogleTranslate : SeleniumRun, ITranslator
    {
        private string _textToTranslate;
        private string _targetLanguage;
        private string _textTranslated;

        public GoogleTranslate() : base()
        {
        }

        protected override void Run()
        {
            _textTranslated = String.Empty;
            try
            {
                string url = String.Format(@"https://translate.google.com/#view=home&op=translate&sl=auto&tl={0}&text={1}", _targetLanguage, HttpUtility.UrlEncode(_textToTranslate));
                Driver.Navigate().GoToUrl(url);
                var translateText = Driver.FindElement(By.CssSelector("span[class*='tlid-translation translation']"));
                _textTranslated = translateText.Text;
            }
            catch (Exception e)
            {
                GerenciadorSaida.SaidaConsole.EscreverTexto($"Não foi possível traduzir texto {_textToTranslate}. Erro: {e.Message}");
                GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);
            }
        }

        public string Traduzir(string message, string targetLanguage)
        {
            _textToTranslate = message;
            _targetLanguage = targetLanguage;
            Run();
            return _textTranslated;
        }
    }
}