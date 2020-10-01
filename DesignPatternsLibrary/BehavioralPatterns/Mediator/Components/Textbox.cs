namespace DesignPatterns.BehavioralPatterns.Mediator.Components
{
    public class Textbox : Component
    {
        public string Caption { get; set; }

        public Textbox(IMediator mediator, string caption) : base(mediator)
        {
            Caption = caption;
        }

        public override void Click()
        {
            Mediator.Notify(this, $"Textbox {Caption} foi clicado!");
        }

        public override void Keypress()
        {
            Mediator.Notify(this, $"Foi pressionado algo sobre o foco do textbox {Caption}.");
        }
    }
}