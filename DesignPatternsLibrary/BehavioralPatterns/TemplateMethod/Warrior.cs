namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public abstract class Warrior
    {
        protected ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;

        public abstract void EquipHelmet();

        public abstract void EquipSword();

        public void Fight()
        {
            EquipHelmet();
            EquipSword();
            Output.EscreverTexto("Lutar");
        }
    }
}