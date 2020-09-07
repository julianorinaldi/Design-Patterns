
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class Universo
    {
        // Usado para controlas a instância, por isso é estático
        private static volatile Universo instance;
        private static object syncRootObject = new object();
        private List<Galaxia> _galaxias;

        private Universo()
        {
            _galaxias = new List<Galaxia>();
        }

        public static Universo GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRootObject)
                    {
                        if (instance == null)
                        {
                            instance = new Universo();
                        }
                    }
                }
                return instance;
            }
        }


        public void AdicionaGalaxia(Galaxia galaxia)
        {
            // Simples adição sem validações
            _galaxias.Add(galaxia);
        }

        public string MinhasGalaxias()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Minhas galáxias são: ");
            foreach (var galaxia in _galaxias)
            {
                sb.AppendLine($"Nome: {galaxia.Nome}");
            }

            return sb.ToString();
        }
    }
}