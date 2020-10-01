namespace DesignPatterns.BehavioralPatterns.Mediator.Components
{
    public class Button : Component
    {
        public string Caption { get; set; }

        public Button(IMediator mediator, string caption) : base(mediator)
        {
            Caption = caption;
        }

        public override void Click()
        {
            Mediator.Notify(this, $"Botão {Caption} foi clicado!");
        }

        public override void Keypress()
        {
            Mediator.Notify(this, $"Foi pressionado algo sobre o foco do botão {Caption}.");
        }
    }
}