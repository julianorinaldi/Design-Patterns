using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DesignPatterns.StructurePatterns.Decorator
{
    public class EncripitadorDeDados : DadosDecorator
    {
        private static string EncryptionKey = "CHAVE";

        public EncripitadorDeDados(IDados dados)
            : base(dados)
        {
            dados.EscreverDados(EncriptarDados(dados.LerDados()));
        }

        public override string LerDados()
        {
            // Desencriptar dados
            return DesencriptarDados(Dados.LerDados());
        }

        public override void EscreverDados(string text)
        {
            // Encriptar dados
            Dados.EscreverDados(EncriptarDados(text));
        }

        private string EncriptarDados(string conteudo)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(conteudo);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    conteudo = Convert.ToBase64String(ms.ToArray());
                }
            }
            return conteudo;
        }

        private string DesencriptarDados(string conteudoEncriptado)
        {
            conteudoEncriptado = conteudoEncriptado.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(conteudoEncriptado);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    conteudoEncriptado = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return conteudoEncriptado;
        }
    }
}