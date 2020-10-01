namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public abstract class Component
    {
        protected IMediator Mediator;

        public Component(IMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Click();

        public abstract void Keypress();
    }
}