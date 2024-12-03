using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace BancoDeDados
{
    public partial class frmConfBcoDados : Form
    {
        BcoDados b = new BcoDados();
        Funcoes func = new Funcoes();        
        Xml xml =new Xml();
        Criptografia crypto = new Criptografia();
        ArquivosEPastas arq = new ArquivosEPastas();


        public frmConfBcoDados()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConfBcoDados_Load(object sender, EventArgs e)       {
            

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

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            salvar();   
        }

        private void salvar()
        {
            var bco = new BcoDados()
            {
                datasource = txtServidor.Text,
                database = txtBcoDados.Text,
                port = txtPorta.Text,
                user = txtLogin.Text,
                password = crypto.Criptografar(txtSenha.Text)
            };

            bco.salvarConfiguracao(bco);
        }

        private void reset()
        {            

            var bco = new BcoDados().lerXMLConfiguracao();

                
            if (bco != null)
            {
                txtServidor.Text = bco.datasource;
                txtBcoDados.Text = bco.database;
                txtPorta.Text = bco.port;
                txtLogin.Text = bco.user;
                txtSenha.Text = bco.password;
            }
            else { 
                txtServidor.Text = string.Empty;
                txtBcoDados.Text = string.Empty;
                txtPorta.Text = string.Empty; 
                
                txtSenha.Text = string.Empty; 
            }

            txtServidor.Focus();

        }

        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            if (b.testeDeConexao())
            {
                MessageBox.Show("Conexao OK!");
            }
            else
            {
                MessageBox.Show("Conexao Falhou");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBcoDados.Text = arq.arquivoFdb(opfile);
        }
    }
}
