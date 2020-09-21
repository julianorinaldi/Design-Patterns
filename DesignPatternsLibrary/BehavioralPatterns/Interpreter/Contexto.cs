namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public class Contexto
    {
        public string EntradaTexto { get; set; }
        public string Traduzido { get; set; }

        public Contexto(string entradaTexto)
        {
            EntradaTexto = entradaTexto;
        }
    }
}