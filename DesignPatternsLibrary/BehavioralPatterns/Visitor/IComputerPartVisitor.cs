namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public interface IComputerPartVisitor
    {
        public void Visit(Computer computer);

        public void Visit(Mouse mouse);

        public void Visit(Keyboard keyboard);

        public void Visit(Monitor monitor);
    }
}