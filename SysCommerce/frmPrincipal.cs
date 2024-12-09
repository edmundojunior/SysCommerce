using BancoDeDados;
using CertDigital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace SysCommerce
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Funcoes func = new Funcoes();

            this.Text = ".: SysCommerce Gerenciador Comercial :. ver.: " + func.ObterVersaoDoProjeto();
            lblData.Text = func.ObterDataAtualPorExtenso();
            timer1.Start();

        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfBcoDados frm = new frmConfBcoDados();
            frm.ShowDialog();

        }

        private void certificadoDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCertificado frm = new frmCertificado();
            frm.ShowDialog();   
        }
    }
}
