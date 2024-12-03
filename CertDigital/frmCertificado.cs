using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace CertDigital
{
    public partial class frmCertificado : Form
    {
        Certificado_Digital cert = new Certificado_Digital();
        Criptografia crypto = new Criptografia();
        dadosCertificado dados= new dadosCertificado();
        ArquivosEPastas selec = new ArquivosEPastas();      


        public frmCertificado()
        {
            InitializeComponent();
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                cert.CertificadoSelecionadoField = null;

                cert.thumbPrintCertificado = null;

                selecionarCertificado();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        

        private void selecionarCertificado()
        {

            try
            {
                if (chkRepositorio.Checked == false)
                {

                    cert.PathCertificadoDigital = selec.arquivoPfx(opfile);

                    frmSenhaCert frm = new frmSenhaCert();
                    frm.ShowDialog();

                    cert.SenhaCertificadoDigital = frm.senhaInformada;
                }


                dados = cert.retornaDadosCertificado();
                preenchendoCampo(dados);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmCertificado_Load(object sender, EventArgs e)
        {
            try
            {
                dados = cert.retornaDadosGravadosCertificado();
                preenchendoCampo(dados);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void preenchendoCampo(dadosCertificado dados)
        {
            try
            {
                lblCertificado.Text = (dados.arquivoOriginal == "" || dados.arquivoOriginal == null) ? dados.subject : crypto.Descriptografar(dados.arquivoOriginal);
                lblSerialNumber.Text = dados.serialNumber;
                lblThumbprint.Text = dados.thumbprint;
                chkRepositorio.Checked = !dados.arquivo;


                cert.retornaVencimento(dados.NotAfter);

                string mensagemVencimento = string.Empty;
                if (cert.VencimentoCertificadoDigial >= 0)
                {
                    mensagemVencimento += cert.VencimentoCertificadoDigial.ToString() + " Dia(s) para o Vencimento ";
                }
                else
                {
                    mensagemVencimento += "Cerificado vencido a " + (cert.VencimentoCertificadoDigial * (-1)).ToString() + " Dia(s)";
                }

                lblValidade.Text = "de: " + dados.NotBefore.ToString() + " à " + dados.NotAfter.ToString() + "\n " + mensagemVencimento;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lblCertificado_Click(object sender, EventArgs e)
        {

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                cert.salvarXmlCertificado(dados);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
