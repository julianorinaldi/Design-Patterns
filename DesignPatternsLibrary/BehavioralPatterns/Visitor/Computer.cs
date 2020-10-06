namespace DesignPatterns.BehavioralPatterns.Visitor
{
    public class Computer : IComputerPart
    {
        private IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}