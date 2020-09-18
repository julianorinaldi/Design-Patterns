using System.IO;

namespace DesignPatterns.StructurePatterns.Facade
{
    public class ConverteFormato
    {
        public AnaliseVideo Analise { get; }

        public FormatoVideo Formato { get; }

        public ConverteFormato(AnaliseVideo analise, FormatoVideo formato)
        {
            Analise = analise;
            Formato = formato;
        }

        public Stream ConverteVideo()
        {
            // Aqui faz a conversão do vídeo para o formato
            switch (Formato)
            {
                case FormatoVideo.AVI:
                    break;

                case FormatoVideo.WMA:
                    break;

                case FormatoVideo.MOV:
                    break;

                case FormatoVideo.MPEG:
                    break;

                default:
                    break;
            }

            return null;
        }
    }
}