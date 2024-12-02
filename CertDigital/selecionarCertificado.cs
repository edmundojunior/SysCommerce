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



namespace CertDigital
{

    public class dadosCertificado
    {
        public dadosCertificado() { }

        public  string tipoCertificado { get; set; } = null; // A1 ou A3
        public bool arquivo { get; set; } = false;
        public string issuer {  get; set; }
        public string serialNumber { get;set; }
        public string subject { get; set;}
        public string thumbprint { get; set; }
        public DateTime NotAfter { get; set; } = DateTime.Now;
        public DateTime NotBefore { get; set; } = DateTime.Now;
        public string certificadoBase64 { get; set; } = null;
        public string senhaCertificado { get; set; } = null;

    }
    
    public  class selecionarCertificado
    {

        public  string PathCertificadoDigital { get; set; }
        public  string SenhaCertificadoDigital { get; set; }
        public int VencimentoCertificadoDigial { get; set; } = 0;
        public string thumbPrintCertificado { get; set; } = null;

        public  X509Certificate2 CertificadoSelecionadoField;

        dadosCertificado dados = new dadosCertificado();

        public void retornaVencimento(DateTime dtFinal)
        {            
            
            try
            {
                TimeSpan diferenca = dtFinal - DateTime.Now;

                VencimentoCertificadoDigial = diferenca.Days;
            }
            catch (ArgumentException ex)
            {
                
                MessageBox.Show("Ops!\n" + ex.Message, "Ocorreu um problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        public X509Certificate2 BuscarCertificadoSelecionadoArquivo
        {

            get
            {
                if (CertificadoSelecionadoField == null)
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);

                }

                return CertificadoSelecionadoField;
            }

            private set => throw new Exception("Não é possível atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");
        }


        public X509Certificate2 CertificadoSelecionadoArquivo
        {            
            
            get
            {
                if (CertificadoSelecionadoField == null)
                {
                    CertificadoSelecionadoField = new CertificadoDigital().CarregarCertificadoDigitalA1(PathCertificadoDigital, SenhaCertificadoDigital);

                }

                return CertificadoSelecionadoField;
            }

            private set => throw new Exception("Não é possível atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");
        }
        
        public dadosCertificado cert = new dadosCertificado();

        public X509Certificate2 BuscarCertificadoSelecionado
        {
            get
            {
                CertificadoSelecionadoField = new CertificadoDigital().BuscarCertificadoDigital(thumbPrintCertificado);

                return CertificadoSelecionadoField;
            }

            private set => throw new Exception("Não é possível atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");

        }

        public X509Certificate2 CertificadoSelecionado
        {
            get
            {
                if (CertificadoSelecionadoField == null)
                {
                    CertificadoSelecionadoField = new CertificadoDigital().AbrirTelaSelecao();

                    if (CertificadoSelecionadoField.IsA3())
                    {
                        //Setar o PIN
                        CertificadoSelecionadoField.SetPinPrivateKey("");
                        
                    }
                }

                return CertificadoSelecionadoField;
            }

            private set => throw new Exception("Não é possível atribuir um certificado digital! Somente resgate o valor da propriedade que o certificado é definido automaticamente.");

        }

        public dadosCertificado retornarCertificadoSelecionado(string caminho)
        {
            dadosCertificado retorno = new dadosCertificado();            
            X509Certificate2 cert = new X509Certificate2();
            Criptografia crypto = new Criptografia();
            Xml xml = new Xml();
            ArquivosEPastas arq = new ArquivosEPastas();

            
            try
            {
                if (File.Exists(caminho))
                {
                    bool ehArquivo = Convert.ToBoolean(xml.Ler_XML("arquivo", 1, caminho));
                    string arqConfig = arq.retornaPastaPadrao();

                    arqConfig += "temp.pfx";

                    if (ehArquivo)
                    {
                        PathCertificadoDigital = crypto.ConverterBase64ParaArquivo(xml.Ler_XML("certificadoBase64", 1, caminho),arqConfig);
                        SenhaCertificadoDigital = crypto.Descriptografar(xml.Ler_XML("senhaCertificado", 1, caminho));

                        cert = CertificadoSelecionadoArquivo;
                        retorno.certificadoBase64 = xml.Ler_XML("certificadoBase64", 1, caminho);
                        retorno.senhaCertificado = xml.Ler_XML("senhaCertificado", 1, caminho);

                        if (File.Exists(arqConfig)) File.Delete(arqConfig);

                    }
                    else
                    {

                        thumbPrintCertificado = xml.Ler_XML("thumbprint", 1,caminho);
                        cert = BuscarCertificadoSelecionado;

                        retorno.certificadoBase64 = "";
                        retorno.senhaCertificado = "";


                    }

                    if (cert != null)
                    {
                        if (cert.IsA3())
                        {
                            retorno.tipoCertificado = "A3";
                        }
                        else
                        {
                            retorno.tipoCertificado = "A1";
                        }

                        //dados do certificado
                        retorno.arquivo = ehArquivo;
                        retorno.issuer = cert.Issuer;
                        retorno.serialNumber = cert.SerialNumber;
                        retorno.subject = cert.Subject;
                        retorno.thumbprint = cert.Thumbprint;
                        retorno.NotAfter = cert.NotAfter;
                        retorno.NotBefore = cert.NotBefore;
                        retornaVencimento(cert.NotAfter);

                    }
                    else
                    {
                        retorno = null;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ops! Não foi possível abrir o arquivo de configuração '{caminho}'\n" + ex.Message, "Ocorreu um problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        public dadosCertificado retornaCertificado(bool arquivo, string certificado = null, string senha=null)

        {
            dadosCertificado retorno = new dadosCertificado();
            X509Certificate2 cert = new X509Certificate2();
            Criptografia crypto = new Criptografia();

            //retorno = null;
            
            try
            {
                if (arquivo)
                {
                    
                    
                        cert = CertificadoSelecionadoArquivo;
                        retorno.certificadoBase64 = crypto.ConverterArquivoParaBase64(certificado);
                        retorno.senhaCertificado = crypto.Criptografar(senha);
                    

                }
                else
                {

                    
                        cert = CertificadoSelecionado;
                        retorno.certificadoBase64 = "";
                        retorno.senhaCertificado = "";
                    
                     
                }

                if (cert != null)
                {
                    if (cert.IsA3() )
                    {
                        retorno.tipoCertificado = "A3";
                    }
                    else
                    {
                        retorno.tipoCertificado = "A1";
                    }

                    //dados do certificado
                    retorno.arquivo = arquivo;
                    retorno.issuer = cert.Issuer;
                    retorno.serialNumber = cert.SerialNumber;
                    retorno.subject = cert.Subject;
                    retorno.thumbprint = cert.Thumbprint;
                    retorno.NotAfter = cert.NotAfter;
                    retorno.NotBefore = cert.NotBefore;
                    retornaVencimento(cert.NotAfter);

                } else
                {
                    retorno = null;
                }               

                try
                {
                    if (retorno != null)
                    {
                        
                        salvarXmlCertificado(retorno);
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um certificado digital válido!","Aviso Importante");
                    }
                    
                }
                catch(ArgumentException ex)
                {
                    MessageBox.Show("Ops!\n" + ex.Message, "Ocorreu um problema!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception) {

                MessageBox.Show("Dados do certificado não encontrado","Aviso Importante");
            }

            return retorno;

        }

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
                
                if (File.Exists(caminho)) MessageBox.Show("Certificado Configurado!","Certificado Digital", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                throw new ArgumentException($"Não foi possível salvar o arquivo ' {caminho} ' \n de configuração");
            }

        }
    }

}
