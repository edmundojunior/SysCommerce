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
    public partial class frmSenhaCert : Form
    {
        public string senhaInformada = string.Empty;
        public frmSenhaCert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            senhaInformada =txtSenha.Text ;
            Close();
        }
    }
}
