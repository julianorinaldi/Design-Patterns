namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public interface IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}