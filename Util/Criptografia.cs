using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Unimake.Business.DFe.Xml.ESocial.Retorno;

namespace Util
{
    public class Criptografia
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("AY2DExGHIzKLMNOJkPejutlOEMAOEoiX"); // Deve ter 16, 24 ou 32 bytes
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("23GEJIRNDSKD234W"); // Deve ter 16 bytes

        public string Criptografar(string textoPlano)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(textoPlano);
                    }

                    byte[] encrypted = msEncrypt.ToArray();
                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        public string Descriptografar(string textoCriptografado)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textoCriptografado)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }

        public string ConverterArquivoParaBase64(string caminhoArquivo)
        {
            byte[] arquivoBytes = File.ReadAllBytes(caminhoArquivo);
            return Convert.ToBase64String(arquivoBytes);
        }

        public string  ConverterBase64ParaArquivo(string base64String, string caminhoDestino)
        {
            if (File.Exists(caminhoDestino)) File.Delete(caminhoDestino);

            
            byte[] arquivoBytes = Convert.FromBase64String(base64String);
            File.WriteAllBytes(caminhoDestino, arquivoBytes);

            return caminhoDestino;

        }

        public string GerarHashMD5(string texto)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

    }
}
