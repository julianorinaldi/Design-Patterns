namespace DesignPatterns.BehavioralPatterns.TemplateMethod
{
    public class WarriorWood : Warrior
    {
        public override void EquipHelmet()
        {
            Output.EscreverTexto("Equipado com capacete de Madeira");
        }

        public override void EquipSword()
        {
            Output.EscreverTexto("Equipado com espada de Madeira");
        }
    }
}