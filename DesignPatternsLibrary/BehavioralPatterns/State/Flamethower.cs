namespace DesignPatterns.BehavioralPatterns.State
{
    public class Flamethower : IWeapon
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public void Shoot()
        {
            Output.EscreverTexto("Lança fogo");
        }
    }
}