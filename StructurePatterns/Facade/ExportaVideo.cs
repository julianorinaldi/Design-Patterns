using System.IO;

namespace DesignPatterns.StructurePatterns.Facade
{
    public class ExportaVideo
    {
        private ConverteFormato _converteFormato;

        private Stream _streamVideo;
        public AnaliseVideo Analise { get { return _converteFormato.Analise; } }

        private DirectoryInfo _dirDestino;

        public ExportaVideo(ConverteFormato convertedor, DirectoryInfo dirDestino)
        {
            _converteFormato = convertedor;
            _dirDestino = dirDestino;
        }

        public ExportaVideo(Stream steamVideo, DirectoryInfo dirDestino)
        {
            _streamVideo = steamVideo;
            _dirDestino = dirDestino;
        }

        public void Exportar()
        {
            if (_streamVideo == null)
            {
                //Carregar stream
                _streamVideo = _converteFormato.ConverteVideo();
            }

            if (_dirDestino.Exists)
            {
                // Exporta o arquivo para o diretório
            }
        }
    }
}