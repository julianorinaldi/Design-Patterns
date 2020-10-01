namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public interface IMediator
    {
        public void Notify(Component component, string msg);
    }
}