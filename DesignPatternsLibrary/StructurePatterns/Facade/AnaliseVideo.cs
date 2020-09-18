using System.IO;

namespace DesignPatterns.StructurePatterns.Facade
{
    public class AnaliseVideo
    {
        public FileInfo Video { get; }

        public AnaliseVideo(FileInfo video)
        {
            Video = video;
        }

        public void ExtraiInformacoesVideo()
        {
            // Fará a estudo do vídeo atual
        }
    }
}