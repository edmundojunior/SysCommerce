using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml;
using Unimake.Business.DFe.Servicos;
using Unimake.Business.DFe.Utility;
using Unimake.Security.Platform;
using Unimake.Security.Platform.Exceptions;
using ServicoMDFe = Unimake.Business.DFe.Servicos.MDFe;
using ServicoNFCe = Unimake.Business.DFe.Servicos.NFCe;
using ServicoNFe = Unimake.Business.DFe.Servicos.NFe;
using ServicoNFSe = Unimake.Business.DFe.Servicos.NFSe;
using ServicoCTe = Unimake.Business.DFe.Servicos.CTe;
using XmlMDFe = Unimake.Business.DFe.Xml.MDFe;
using XmlNFe = Unimake.Business.DFe.Xml.NFe;
using XmlCTe = Unimake.Business.DFe.Xml.CTe;
using Unimake.Business.DFe.Security;
using Util;
using System.Xml.Serialization;
using Org.BouncyCastle.Tls;
using System.Data;



namespace CertDigital
{

    public class dadosCertificado
    {
        public dadosCertificado() { }

        public  string tipoCertificado { get; set; } = null; // A1 ou A3
        public bool arquivo { get; set; } = false; // certificado selecionado é ou não arquivo
        public string issuer { get; set; } = null;
        public string serialNumber { get; set; } = null;
        public string subject { get; set; } = null;
        public string thumbprint { get; set; } = null;
        public DateTime NotAfter { get; set; } = DateTime.Now;
        public DateTime NotBefore { get; set; } = DateTime.Now;
        public string arquivoOriginal { get; set; } = null;     
        public string certificadoBase64 { get; set; } = null;
        public string senhaCertificado { get; set; } = null;

    }

    public class Certificado_Digital
    {
        public Certificado_Digital() { }

        #region Propriedade
        public string PathCertificadoDigital { get; set; } = null;
        public string SenhaCertificadoDigital { get; set; } = null;
        public int VencimentoCertificadoDigial { get; set; } = 0;
        public string thumbPrintCertificado { get; set; } = null;
        public X509Certificate2 CertificadoSelecionadoField { get; set; } = null;

        #endregion

        #region Metodos

        ArquivosEPastas arqPasta = new ArquivosEPastas();
        Xml xml = new Xml();
        Criptografia crypto = new Criptografia();

        /// <summary>
        /// Calcular o vencimento do um determinado certificado digital
        /// </summary>
        /// <param name="dtFinal"></param>
        /// <exception cref="ArgumentException"></exception>
        public void retornaVencimento(DateTime dtFinal)
        {
                     
            try
            {
                TimeSpan diferenca = dtFinal - DateTime.Now;

                VencimentoCertificadoDigial = diferenca.Days;
            }
            catch(Exception ex)
            {
                VencimentoCertificadoDigial = 0;
                throw new ArgumentException("Ops!, ocorreu um problema ao calcular o vencimento do Certificado Digital\n" + ex.Message);
               
            }
                      
        }

        /// <summary>
        /// Salva os dados do Certificado Selecionado em um arquivo xml
        /// arquivo: ConfiguracaoCertificadoDigital.xml
        /// </summary>
        /// <param name="dados"></param>
        /// <exception cref="ArgumentException"></exception>
        public void salvarXmlCertificado(dadosCertificado dados)
        {

            ArquivosEPastas arqPasta = new ArquivosEPastas();

            string caminho = arqPasta.retornaPastaPadrao() + "ConfiguracaoCertificadoDigital.xml";
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(dadosCertificado));

                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    serializer.Serialize(writer, dados);
                }

                if (File.Exists(caminho)) MessageBox.Show($"Certificado Configurado com Sucesso!\n ' {caminho}' ", "Certificado Digital", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw new ArgumentException($"Não foi possível salvar o arquivo ' {caminho} ' \n de configuração");
            }

        }

        public dadosCertificado retornaDadosGravadosCertificado()
        {
            dadosCertificado dados = new dadosCertificado();            
            
            Criptografia crypto = new Criptografia();            

            string caminho = arqPasta.retornaPastaPadrao() + "ConfiguracaoCertificadoDigital.xml";            

            if (File.Exists(caminho))
            {

                thumbPrintCertificado = xml.Ler_XML("thumbprint", 1, caminho);

                PathCertificadoDigital = null;
                SenhaCertificadoDigital = null;

                if (Convert.ToBoolean( xml.Ler_XML("arquivo", 1, caminho)))
                {

                    string arquivoOriginal = crypto.Descriptografar(xml.Ler_XML("arquivoOriginal", 1, caminho));
                    PathCertificadoDigital = crypto.ConverterBase64ParaArquivo(xml.Ler_XML("certificadoBase64", 1, caminho),arquivoOriginal);
                    SenhaCertificadoDigital = crypto.Descriptografar(xml.Ler_XML("senhaCertificado", 1, caminho));
                    

                }

                certificadoSelecionado();

                if (CertificadoSelecionadoField != null)
                {


                    dados.tipoCertificado = CertificadoSelecionadoField.IsA3() ? "A3" : "A1";
                    dados.arquivo = PathCertificadoDigital != null ? true : false;
                    dados.issuer = CertificadoSelecionadoField.Issuer;
                    dados.serialNumber = CertificadoSelecionadoField.SerialNumber;
                    dados.subject = CertificadoSelecionadoField.Subject;
                    dados.thumbprint = CertificadoSelecionadoField.Thumbprint;
                    dados.NotAfter = CertificadoSelecionadoField.NotAfter;
                    dados.NotBefore = CertificadoSelecionadoField.NotBefore;
                    dados.arquivoOriginal = PathCertificadoDigital == null ? "" : crypto.Criptografar(PathCertificadoDigital);
                    dados.certificadoBase64 = PathCertificadoDigital == null ? "" : crypto.ConverterArquivoParaBase64(PathCertificadoDigital);
                    dados.senhaCertificado = SenhaCertificadoDigital == null ? "" : crypto.Criptografar(SenhaCertificadoDigital);
                }
                
            }
            else
            {
                MessageBox.Show($"Arquivo de Configuração '{caminho}' não encontrado ", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dados = null;
            }

            return dados;
        }
        /// <summary>
        /// seleciona o certificado digital a ser usado
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void certificadoSelecionado()
        {
            try
            {
                if (thumbPrintCertificado == null && (PathCertificadoDigital == null && SenhaCertificadoDigital == null))
                {
                    CertificadoSelecionadoField = new CertificadoDigital().AbrirTelaSelecao();
                    
                    if (CertificadoSelecionadoField != null)
                    {
                        if (CertificadoSelecionadoField.IsA3()) CertificadoSelecionadoField.SetPinPrivateKey("");
                    }
                    else
                    {
                        CertificadoSelecionadoField = null;
                        MessageBox.Show("Não foi selecinado um certificado válido", "Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        return;
                    }
                    
                    
                }
                else if (thumbPrintCertificado != null && (PathCertificadoDigital == null && SenhaCertificadoDigital == null))
                {
                    CertificadoSelecionadoField = new CertificadoDigital().BuscarCertificadoDigital(thumbPrintCertificado);

                    if (CertificadoSelecionadoField.IsA3()) CertificadoSelecionadoField.SetPinPrivateKey("");
                }
                else
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);
                }
            }
            catch (Exception ex)
            {
                CertificadoSelecionadoField = null;
                throw new ArgumentException("Ops! Ocorreu um problema ao selecionar o certificado digital [certificadoSelecionado()]\n" + ex.Message + "\n");
            }
        }

        public dadosCertificado retornaDadosCertificado() 
        {
            dadosCertificado dados = new dadosCertificado();
            

            try
            {
                certificadoSelecionado();

                if (CertificadoSelecionadoField != null)
                {
                    dados.tipoCertificado = CertificadoSelecionadoField.IsA3() ? "A3" : "A1";
                    dados.arquivo = PathCertificadoDigital != null ? true : false;
                    dados.issuer = CertificadoSelecionadoField.Issuer;
                    dados.serialNumber = CertificadoSelecionadoField.SerialNumber;
                    dados.subject = CertificadoSelecionadoField.Subject;
                    dados.thumbprint = CertificadoSelecionadoField.Thumbprint;
                    dados.NotAfter = CertificadoSelecionadoField.NotAfter;
                    dados.NotBefore = CertificadoSelecionadoField.NotBefore;
                    dados.arquivoOriginal = PathCertificadoDigital == null ? "" : crypto.Criptografar(PathCertificadoDigital);
                    dados.certificadoBase64 = PathCertificadoDigital == null ? "" : crypto.ConverterArquivoParaBase64(PathCertificadoDigital);
                    dados.senhaCertificado = SenhaCertificadoDigital == null ? "" : crypto.Criptografar(SenhaCertificadoDigital);
                }                

            }
            catch(Exception ex)
            {
                dados = null;
                throw new ArgumentException("Ops! Ocorreu um problema ao retornar os dados do certificado [retornaDadosCertificado]\n" + ex.Message + "\n");
            }

            return dados;

        }

        public X509Certificate2 certificadoUsando()
        {

            string caminho = arqPasta.retornaPastaPadrao() + "ConfiguracaoCertificadoDigital.xml";

            X509Certificate2 cert = new X509Certificate2();

            try
            {
                if (File.Exists(caminho))
                {
                    if (Convert.ToBoolean(xml.Ler_XML("arquivo", 1, caminho)))
                    {
                        cert = new CertificadoDigital().CarregarCertificadoDigitalA1(crypto.ConverterBase64ParaArquivo(xml.Ler_XML("certificadoBase64", 1, caminho), crypto.Descriptografar(xml.Ler_XML("arquivoOriginal", 1, caminho))), crypto.Descriptografar(xml.Ler_XML("senhaCertificado", 1, caminho)));
                    }
                    else
                    {
                        cert = new CertificadoDigital().BuscarCertificadoDigital(xml.Ler_XML("thumbprint", 1, caminho));
                    }
                }
                else
                {
                    cert = null;
                    MessageBox.Show("Não foi encontrado nenhum Certificado Digital encontrado","Aviso Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                cert = null;
                throw new ArgumentException("Não foi encontrado nenhum Certificado Digital encontrado\n" + ex.Message + "\n");
            }

            return cert;


        }

        #endregion 
    }

    

}
