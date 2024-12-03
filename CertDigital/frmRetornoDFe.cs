using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertDigital
{
    public partial class frmRetornoDFe : Form
    {

        public string codigoSefaz = null;
        public string descricaoSefaz = null;
        public bool rejeicaoSefaz = false;

        public frmRetornoDFe(string codigo = null,
                             string descricao = null,
                             bool rejeicao = false)
        {
            InitializeComponent();

            codigoSefaz = codigo;
            descricaoSefaz = descricao;
            rejeicaoSefaz = rejeicao;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRetornoDFe_Load(object sender, EventArgs e)
        {
            if (rejeicaoSefaz)
            {
                pctfeliz.Visible = false;
                pcttriste.Visible = true;
            }
            else
            {
                pctfeliz.Visible = true;
                pcttriste.Visible = false;
            }


            lblCodigoSefaz.Text = codigoSefaz;
            lblDescricao.Text = descricaoSefaz; 

        }
    }
}
