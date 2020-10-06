namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}