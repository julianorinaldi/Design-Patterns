using DesignPatternsConsole;
using System.Collections.Generic;

namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class Forest
    {
        private List<Tree> Trees = new List<Tree>();

        public Tree PlantTree(int x, int y, string name, string color, string texture)
        {
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Criando árvore:{name}\tEixoX:{x}\tEixoY:{y}\tCor:{color}\tTextura:{texture}");
            var type = TreeFactory.GetTreeType(name, color, texture);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Quantidade Objetos FlyWeight: {TreeFactory.GetAmountObjectsFlyWeight()}");
            var tree = new Tree(x, y, type);
            Trees.Add(tree);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Quantidade de Árvores: {Trees.Count}");
            return tree;
        }

        public void Draw()
        {
            foreach (var tree in Trees)
            {
                GerenciadorSaida.TelaGraficaConsole.Draw(tree.EixoX, tree.EixoY);
            }
            GerenciadorSaida.TelaGraficaConsole.Show();
        }
    }
}