using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public  class ArquivosEPastas
    {
        public string retornaPastaPadrao()
        {
            string retorno = string.Empty;

            try
            {
                retorno = System.AppDomain.CurrentDomain.BaseDirectory.ToString() ;
            }
            catch (Exception)
            {
                retorno = @"C:\";
            }

            return retorno;
        }

        /// <summary>
        /// Pasta
        /// </summary>
        /// <param name="fbd"></param>
        /// <returns></returns>
        public string Pasta(System.Windows.Forms.FolderBrowserDialog fbd)
        {
            string retorno = string.Empty;

            fbd.Description = "Selecione uma pasta ";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = true;


            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                retorno = fbd.SelectedPath;
            }

            return retorno;
        }

        /// <summary>
        /// Arquivo
        /// </summary>
        /// <param name="opfile"></param>
        /// <returns></returns>
        public string arquivoXML(System.Windows.Forms.OpenFileDialog opfile)
        {
            string arqGeral = string.Empty;

            opfile.Title = "Selecione arquivo Xml de Entrada";
            opfile.Filter = "Arquivo (*.*)| *.*|" + "Arquivo  (*.xml)|*.xml";
            opfile.FilterIndex = 2;
            opfile.RestoreDirectory = true;
            opfile.ReadOnlyChecked = true;
            opfile.ShowReadOnly = true;

            opfile.ShowDialog();

            arqGeral = opfile.FileName;

            return arqGeral;
        }

        public string arquivoPfx(System.Windows.Forms.OpenFileDialog opfile)
        {
            string arqGeral = string.Empty;

            opfile.Title = "Selecione Arquivo de Certificado Digital";
            opfile.Filter = "Arquivo (*.*)| *.*|" + "Arquivo  (*.pfx)|*.pfx";
            opfile.FilterIndex = 2;
            opfile.RestoreDirectory = true;
            opfile.ReadOnlyChecked = true;
            opfile.ShowReadOnly = true;

            opfile.ShowDialog();

            arqGeral = opfile.FileName;

            return arqGeral;
        }
    }
}
