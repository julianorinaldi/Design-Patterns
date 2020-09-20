namespace DesignPatterns.BehavioralPatterns.Command
{
    // Faz o papel de Invoker
    public class Invoker
    {
        protected ICommand Command { get; private set; }

        public void SetCommand(ICommand command)
        {
            Command = command;
        }

        public void ExecuteCommand()
        {
            if (Command != null)
                Command.Execute();
        }
    }
}