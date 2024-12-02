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
        selecionarCertificado cert = new selecionarCertificado();
        dadosCertificado dados= new dadosCertificado();
        ArquivosEPastas selec = new ArquivosEPastas();      


        public frmCertificado()
        {
            InitializeComponent();
        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            cert.CertificadoSelecionadoField = null;

            selecionarCertificado();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void retornaCertificado()

        {
            //Buscar certificado selecionado
            string arqv = selec.retornaPastaPadrao();
            arqv += "ConfiguracaoCertificadoDigital.xml";

            if (File.Exists(arqv))
            {

                dados = cert.retornarCertificadoSelecionado(arqv);

                if (cert.PathCertificadoDigital != null)
                {
                    lblCertificado.Text = cert.PathCertificadoDigital;
                }
                else
                {
                    lblCertificado.Text = dados.subject;
                }        


                string mensagemVencimento = string.Empty;
                if (cert.VencimentoCertificadoDigial >= 0)
                {
                    mensagemVencimento += cert.VencimentoCertificadoDigial.ToString() + " Dia(s) para o Vencimento ";
                }
                else
                {
                    mensagemVencimento += "Cerificado vencido a" + (cert.VencimentoCertificadoDigial * (-1)).ToString();
                }

                lblValidade.Text = "de: " + dados.NotBefore.ToString() + " à " + dados.NotAfter.ToString() + "\n " + mensagemVencimento;

                lblThumbprint.Text = dados.thumbprint;
                lblSerialNumber.Text = dados.serialNumber;

            }

            
        }

        private void selecionarCertificado()
        {
            if (chkRepositorio.Checked == false) {

                cert.PathCertificadoDigital = selec.arquivoPfx(opfile);

                frmSenhaCert frm = new frmSenhaCert();
                frm.ShowDialog();

                cert.SenhaCertificadoDigital = frm.senhaInformada;

                dados = cert.retornaCertificado(true, cert.PathCertificadoDigital, cert.SenhaCertificadoDigital);

                lblCertificado.Text = cert.PathCertificadoDigital;
            }
            else {


                dados = cert.retornaCertificado(false, cert.PathCertificadoDigital, cert.SenhaCertificadoDigital);

                lblCertificado.Text = dados.subject;
            }

            string mensagemVencimento =string.Empty;    
            if (cert.VencimentoCertificadoDigial >= 0)
            {
                mensagemVencimento += cert.VencimentoCertificadoDigial.ToString() + " Dia(s) para o Vencimento ";
            }
            else
            {
                mensagemVencimento += "Cerificado vencido a" + (cert.VencimentoCertificadoDigial * (-1)).ToString();
            }
            
            lblValidade.Text = "de: " + dados.NotBefore.ToString() + " à " + dados.NotAfter.ToString() + "\n " + mensagemVencimento;

            lblThumbprint.Text = dados.thumbprint;
            lblSerialNumber.Text = dados.serialNumber;

        }

        private void frmCertificado_Load(object sender, EventArgs e)
        {
            retornaCertificado();
        }

        private void lblCertificado_Click(object sender, EventArgs e)
        {

        }
    }
}
