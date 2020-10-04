namespace DesignPatterns.BehavioralPatterns.State
{
    public class FireWeapon : IWeapon
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public void Shoot()
        {
            Output.EscreverTexto("Atira fogo");
        }
    }
}