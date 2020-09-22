using DesignPatternsConsole;

namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public void Draw(int eixoX, int eixoY)
        {
            GerenciadorSaida.TelaGraficaConsole.Draw(eixoX, eixoY);
        }

        public override bool Equals(object obj)
        {
            if (this.Name == (obj as TreeType).Name
                && this.Color == (obj as TreeType).Color
                && this.Texture == (obj as TreeType).Texture)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() +
                this.Color.GetHashCode() +
                this.Texture.GetHashCode();
        }
    }
}