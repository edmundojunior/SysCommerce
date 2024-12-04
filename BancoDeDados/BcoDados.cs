using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using Util;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlTypes;

namespace BancoDeDados
{
    public class BcoDados
    {

        Xml xml = new Xml();
        Criptografia crypto = new Criptografia();
        public BcoDados() { }

        #region Propriedades

        public string user { get; set; }
        public string password { get; set; }        
        public string database { get; set; }
        public string datasource { get; set; }
        public string port {  get; set; }

        #endregion

        #region Metodos

        public bool salvarConfiguracao(BcoDados bcoDados)
        {

            bool retorno = false;

            try
            {

                string arquivoConfg = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "ConfbancoDeDados.xml";

                if (File.Exists(arquivoConfg))
                {
                    //Alteração

                    XElement BcoDados = XElement.Load(arquivoConfg);

                    // Altera o valor da tag desejada
                    foreach (PropertyInfo prop in bcoDados.GetType().GetProperties())
                    {
                        // Obtém o nome e o valor de cada propriedade
                        string nomePropriedade = prop.Name;
                        object valorPropriedade = prop.GetValue(bcoDados);

                        XElement tagToModify = BcoDados.Element(nomePropriedade);
                        if (tagToModify != null)
                        {
                            tagToModify.Value = valorPropriedade.ToString();
                        }

                    }

                    // Salva as alterações
                    BcoDados.Save(arquivoConfg);

                    retorno = true;
                }
                else
                {
                    //Inclusão

                    XElement BcoDados = new XElement("BcoDados",
                                        new XElement("datasource", bcoDados.datasource),
                                        new XElement("port", bcoDados.port),
                                        new XElement("database", bcoDados.database),
                                        new XElement("user", bcoDados.user),
                                        new XElement("password", bcoDados.password)
                                        );

                    BcoDados.Save(arquivoConfg);

                    if (File.Exists(arquivoConfg)) retorno = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um problema ao tentar salvar a configuração do Banco de Dados\n" + ex.Message, "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                retorno = false;
            }

            return retorno;
        }

        public BcoDados lerXMLConfiguracao()
        {
            BcoDados bcoDados = new BcoDados();
            
            string arquivoConfg = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "ConfbancoDeDados.xml";

            try
            {

                XElement BcoDados = XElement.Load(arquivoConfg);

                bcoDados.datasource = xml.Ler_XML("datasource", 1, arquivoConfg);
                bcoDados.port = xml.Ler_XML("port", 1, arquivoConfg);
                bcoDados.database = xml.Ler_XML("database", 1, arquivoConfg);
                bcoDados.user = xml.Ler_XML("user", 1, arquivoConfg);
                bcoDados.password = crypto.Descriptografar(xml.Ler_XML("password", 1, arquivoConfg));

            }
            catch
            {
                bcoDados = null;
            }

            return bcoDados;
        }

        public FbConnection conectarDeBanco()
        {
            FbConnection conn;

            conn = null;

            BcoDados dadosBancoDeDados = new BcoDados();

            dadosBancoDeDados = lerXMLConfiguracao();

            try
            {

                if (dadosBancoDeDados ==null) return null;

                string strConn = @"DataSource=" + dadosBancoDeDados.datasource
                                                                + "; Database=" + dadosBancoDeDados.database
                                                                + "; username= " + dadosBancoDeDados.user
                                                                + "; password = " + dadosBancoDeDados.password
                                                                + "; port = " + dadosBancoDeDados.port;


                conn = new FbConnection(strConn);

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                }

                conn.Open();
            }
            catch (Exception ex)
            {

                conn = null;
                MessageBox.Show("Ops! \nBanco de Dados não encontrado" + ex.Message);
            }

            return conn;

        }

        public bool fecharConexao(FbConnection conn)
        {
            bool retorno = false;

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();

                    retorno = true;
                }
            }
            catch (Exception)
            {


                retorno = false;
            }

            return retorno;
        }


        public bool testeDeConexao()
        {
            bool retorno = false;

            FbConnection conn;

            conn = null;

            conn = conectarDeBanco();

            if (conn != null)
                retorno = true;

            return retorno;

        }

        #endregion

    }
}
