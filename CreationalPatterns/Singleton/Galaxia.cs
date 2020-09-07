namespace DesignPatterns.CreationalPatterns.Singleton
{
    public class Galaxia
    {
        private readonly string _nome;
        public string Nome => _nome;
        public Galaxia(string nome)
        {
            _nome = nome;
        }
    }
}