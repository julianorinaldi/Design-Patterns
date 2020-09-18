using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace DesignPatterns.StructurePatterns.FlyWeight
{
    public class TreeFactory
    {
        private static List<TreeType> treeTypesList = new List<TreeType>();

        public static TreeType GetTreeType(TreeType treeType)
        {
            if (!treeTypesList.Contains(treeType))
            {
                treeTypesList.Add(treeType);
                return treeType;
            }

            return treeTypesList.Find(item =>
                                       item.Name == treeType.Name &&
                                       item.Texture == treeType.Texture &&
                                       item.Color == treeType.Color);
        }

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            return GetTreeType(new TreeType(name, color, texture));
        }

        public static int GetAmountObjectsFlyWeight()
        {
            return treeTypesList.Count;
        }
    }
}