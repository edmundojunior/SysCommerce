using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Util
{
    public class Xml
    {
        
        public string Ler_XML(string tag, int ocorrencia, string arquivo)
        {
            int num = 0;
            int num2 = 0;
            int length = 0;
            int num3 = 0;
            string text = string.Empty;
            string empty;
            try
            {
                empty = string.Empty;
                if (File.Exists(arquivo))
                {
                    StreamReader streamReader = new StreamReader(arquivo);
                    for (string text2 = streamReader.ReadLine(); text2 != null; text2 = streamReader.ReadLine())
                    {
                        text = text + text2 + '\r';
                    }
                    for (int i = 1; i <= ocorrencia; i++)
                    {
                        num = text.IndexOf("<" + tag + ">", num + 1);
                        num2 = text.IndexOf("</" + tag + ">", num2 + 1);
                        num3 = num + ("</" + tag + ">").Length;
                        length = num2 - (num + ("<" + tag + ">").Length);
                    }
                    empty = text.Substring(num3 - 1, length);
                    streamReader.Close();
                    return empty;
                }
            }
            catch
            {
                empty = string.Empty;
            }
            return empty;
        }

        public string Ler_XML_String(string tag, int ocorrencia, string linha)
        {

            string text = string.Empty;
            string empty;
            try
            {

                empty = string.Empty;
                int pontoInicial = 0;
                int pontoFinal = 0;
                int rodou = 0;

                //Verificar se a tag informada existe
                if (linha.Contains("<" + tag + ">"))
                {

                    while (ocorrencia > rodou)
                    {
                        if (pontoInicial > 0)
                        {
                            linha = linha.Substring(pontoFinal + ("</" + tag + ">").Length, linha.Length - (pontoFinal + ("</" + tag + ">").Length));

                        }

                        pontoInicial = linha.IndexOf("<" + tag + ">") + ("<" + tag + ">").Length;
                        pontoFinal = linha.IndexOf("</" + tag + ">");

                        empty = linha.Substring((pontoInicial), pontoFinal - pontoInicial);

                        rodou++;
                    }
                }
                else
                {
                    empty = string.Empty;
                }

            }
            catch
            {
                empty = string.Empty;
            }
            return empty;
        }

        public string Ler_XML_XmlNode(XmlNode notaFiscalNode, string tag, int ocorrencia = 1)
        {
            string empty = string.Empty;
            int count = 0;

            // Percorre os nós filhos do nó atual para encontrar a tag desejada
            foreach (XmlNode childNode in notaFiscalNode.ChildNodes)
            {
                if (childNode.Name.Equals(tag, StringComparison.OrdinalIgnoreCase))
                {
                    count++;

                    // Se for a ocorrência desejada, armazena o conteúdo
                    if (count == ocorrencia)
                    {
                        empty = childNode.InnerText;
                        break;
                    }
                }
            }

            return empty;
        }
    }
}
