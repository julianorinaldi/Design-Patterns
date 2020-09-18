namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class Tree
    {
        public int EixoX { get; set; }
        public int EixoY { get; set; }
        public TreeType Type { get; set; }

        public void Draw(IGraphicConsole graphicConsole)
        {
            graphicConsole.Draw(EixoX, EixoY);
        }
    }
}