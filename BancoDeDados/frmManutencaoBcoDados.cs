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

namespace BancoDeDados
{
    public partial class frmManutencaoBcoDados : Form
    {

        BcoDados b = new BcoDados();
        Funcoes func = new Funcoes();
        Xml xml = new Xml();
        Criptografia crypto = new Criptografia();
        ArquivosEPastas arq = new ArquivosEPastas();
        bool arquivoBancoJaExiste = false;

        public frmManutencaoBcoDados()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmManutencaoBcoDados_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.KeyDown += TextBox_KeyDown;
                }
            }

            reset();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita o som padrão do Enter
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void reset()
        {

            var bco = new BcoDados().lerXMLConfiguracao();
            
            lstProcesso.Items.Clear();  


            if (bco != null)
            {
                txtServidor.Text = bco.datasource;                
                txtLocal.Text = Path.GetDirectoryName(bco.database);
                txtBcoDados.Text = Path.GetFileName(bco.database);
                txtPorta.Text = bco.port;
                txtLogin.Text = bco.user;
                txtSenha.Text = bco.password;

                pnlDados.Enabled = false;

                arquivoBancoJaExiste = true;

                //testar banco de dados
                lstProcesso.Items.Add("Banco de Dados Encontrado");
                lstProcesso.Refresh();
                lstProcesso.TopIndex = lstProcesso.Items.Count - 1;

                if (b.testeDeConexao())
                {
                    lstProcesso.Items.Add("Conexao ao Banco de Dados Executada com Sucesso!");
                    lstProcesso.Refresh();
                    lstProcesso.TopIndex = lstProcesso.Items.Count - 1;
                    
                }
                else
                {
                    lstProcesso.Items.Add("Conexao ao Banco de Dados Executada Não Executada!");
                    lstProcesso.Refresh();
                    lstProcesso.TopIndex = lstProcesso.Items.Count - 1;
                }

                
            }
            else
            {
                txtServidor.Text = string.Empty;
                txtLocal.Text = string.Empty ;
                txtBcoDados.Text = string.Empty;
                txtPorta.Text = string.Empty;
                txtLogin.Text = string.Empty;
                txtSenha.Text = string.Empty;

                pnlDados.Enabled = true;

                arquivoBancoJaExiste = false;
            }

            txtServidor.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLocal.Text = arq.Pasta(fbd);
        }

        private void txtPorta_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvar()
        {
            var bco = new BcoDados()
            {
                datasource = txtServidor.Text,
                database = txtLocal.Text + @"\" + txtBcoDados.Text,
                port = txtPorta.Text,
                user = txtLogin.Text,
                password = crypto.Criptografar(txtSenha.Text)
            };

            bco.salvarConfiguracao(bco);
        }

        private void processar(BcoDados bco)
        {
            bco.criarBancodeDados(bco, lstProcesso);

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            var bco = new BcoDados().lerXMLConfiguracao();

            if (bco == null) salvar();

            var bcoNew = new BcoDados().lerXMLConfiguracao();

            processar(bcoNew);
        }
    }
}
