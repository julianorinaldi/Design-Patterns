namespace DesignPatterns.BehavioralPatterns.ChainOfResponsability
{
    public class Bagagem
    {
        public Origem OrigemViagem { get; }

        public string Proprietario { get; }

        public Bagagem(string proprietario, Origem origemViagem)
        {
            Proprietario = proprietario;
            OrigemViagem = origemViagem;
        }
    }
}