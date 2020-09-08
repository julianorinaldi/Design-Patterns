using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class Dado : IDado
    {
        public string FaceFrente { get; set; }
        public string FaceLadoEsquerdo { get; set; }
        public string FaceLadoDireito { get; set; }
        public string FaceAtras { get; set; }
        public string FaceEmCima { get; set; }
        public string FaceEmbaixo { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{nameof(FaceFrente)}: {FaceFrente}\n")
              .Append($"{nameof(FaceLadoEsquerdo)}: {FaceLadoEsquerdo}\n")
              .Append($"{nameof(FaceLadoDireito)}: {FaceLadoDireito}\n")
              .Append($"{nameof(FaceAtras)}: {FaceAtras}\n")
              .Append($"{nameof(FaceEmCima)}: {FaceEmCima}\n")
              .Append($"{nameof(FaceEmbaixo)}: {FaceEmbaixo}\n");

            return sb.ToString();
        }
    }
}