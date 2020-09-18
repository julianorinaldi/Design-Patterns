using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class Tenis
    {
        public string Nome { get; private set; }

        public Sola Sola { get; set; }

        public Estrutura Estrutura { get; set; }

        public Costura Costura { get; set; }

        public Plamilha Palmilha { get; set; }

        public Cadarco Cadarco { get; set; }

        public Tenis(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nome do Tênis: {Nome} \n")
              .Append($"Sola do Tênis: {Sola.MaterialSola} \n")
              .Append($"Estrutura do Tênis: {Estrutura.MaterialEstrutura} \n")
              .Append($"Costura do Tênis: {Costura.TipoCostura} \n")
              .Append($"Palmilha do Tênis: {Palmilha.MaterialPalmilha} \n")
              .Append($"Cadarço do Tênis: {Cadarco.TipoCadarco} \n");
            return sb.ToString();
        }

        public static Tenis Builder(ITenisBuilder builder)
        {
            return builder.BuilderCadarco().
                            BuilderCostura().
                            BuilderEstrutura().
                            BuilderPalmilha().
                            BuilderSola().
                            Builder();
        }
    }
}