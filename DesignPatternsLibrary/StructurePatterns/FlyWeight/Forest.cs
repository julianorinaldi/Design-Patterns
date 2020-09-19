using System.Collections.Generic;

namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class Forest
    {
        private List<Tree> Trees = new List<Tree>();
        private ISaidaDeTexto _saidaDeTexto { get; }

        public Forest(ISaidaDeTexto saidaDeTexto)
        {
            _saidaDeTexto = saidaDeTexto;
        }

        public Tree PlantTree(int x, int y, string name, string color, string texture)
        {
            _saidaDeTexto.EscreverTexto($"Criando árvore:{name}\tEixoX:{x}\tEixoY:{y}\tCor:{color}\tTextura:{texture}");
            var type = TreeFactory.GetTreeType(name, color, texture);
            _saidaDeTexto.EscreverTexto($"Quantidade Objetos FlyWeight: {TreeFactory.GetAmountObjectsFlyWeight()}");
            var tree = new Tree(x, y, type);
            Trees.Add(tree);
            _saidaDeTexto.EscreverTexto($"Quantidade de Árvores: {Trees.Count}");
            return tree;
        }

        public void Draw(IGraphicConsole graphicConsole)
        {
            foreach (var tree in Trees)
            {
                graphicConsole.Draw(tree.EixoX, tree.EixoY);
            }
            graphicConsole.Show();
        }
    }
}