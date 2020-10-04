namespace DesignPatterns.BehavioralPatterns.State
{
    public class WatterWeapon : IWeapon
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public void Shoot()
        {
            Output.EscreverTexto("Atira água");
        }
    }
}