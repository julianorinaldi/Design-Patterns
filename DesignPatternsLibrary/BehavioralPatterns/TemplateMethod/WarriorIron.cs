namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class WarriorIron : Warrior
    {
        public override void EquipHelmet()
        {
            Output.EscreverTexto("Equipado com capacete de Ferro");
        }

        public override void EquipSword()
        {
            Output.EscreverTexto("Equipado com espada de Ferro");
        }
    }
}