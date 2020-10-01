namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class Tree
    {
        public int EixoX { get; set; }
        public int EixoY { get; set; }
        public TreeType Type { get; set; }

        public Tree(int eixoX, int eixoY, TreeType type)
        {
            EixoX = eixoX;
            EixoY = eixoY;
            Type = type;
        }

        public void Draw()
        {
            GerenciadorSaida.TelaGraficaConsole.Draw(EixoX, EixoY);
        }
    }
}