using System.IO;

namespace DesignPatterns.StructurePatterns.Facade
{
    public class VideoConverter
    {
        public FileInfo ArquivoOrigem { get; }

        public VideoConverter(FileInfo arquivoOrigem)
        {
            ArquivoOrigem = arquivoOrigem;
        }

        /// <summary>
        /// Este método que faz o principal papel do Facade
        /// </summary>
        /// <param name="dirDestino">Diretório de destino</param>
        /// <param name="formatoConverter">Formato para conversão</param>
        public void ConverterVideo(DirectoryInfo dirDestino, FormatoVideo formatoConverter)
        {
            AnaliseVideo analise = new AnaliseVideo(ArquivoOrigem);
            analise.ExtraiInformacoesVideo();

            ConverteFormato converteFormato = new ConverteFormato(analise, formatoConverter);
            var streamVideo = converteFormato.ConverteVideo();

            ExportaVideo exportaVideo = new ExportaVideo(streamVideo, dirDestino);
            exportaVideo.Exportar();
        }
    }
}