using System;

namespace DesignPatterns.StructurePatterns.Brigde
{
    public class Impressora
    {
        private IPapel _papel;

        public Impressora(IPapel papel)
        {
            if (papel == null)
                throw new ArgumentNullException();

            _papel = papel;
        }

        public string PapelConfigurado()
        {
            return $"Papel: {_papel.Nome} de Gramatura: {_papel.Gramatura}";
        }

        public string Imprimir()
        {
            return $"Imprimindo no {this.PapelConfigurado()}";
        }
    }
}