namespace DesignPatterns.BehavioralPatterns.Mediator.Components
{
    public class Checkbox : Component
    {
        public string Caption { get; set; }

        public Checkbox(IMediator mediator, string caption) : base(mediator)
        {
            Caption = caption;
        }

        public override void Click()
        {
            Mediator.Notify(this, $"Checkbox {Caption} foi clicado!");
        }

        public override void Keypress()
        {
            Mediator.Notify(this, $"Foi pressionado algo sobre o foco do checkbox {Caption}.");
        }
    }
}