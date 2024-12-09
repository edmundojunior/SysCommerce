namespace BancoDeDados
{
    partial class frmManutencaoBcoDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManutencaoBcoDados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtBcoDados = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.barraProcesso = new System.Windows.Forms.ProgressBar();
            this.lblProcessando = new System.Windows.Forms.Label();
            this.pnlProcssando = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstProcesso = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.pnlProcssando.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pnlDados);
            this.panel1.Controls.Add(this.pnlProcssando);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco de Dados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local do Banco de Dados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porta:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Login:";
            // 
            // txtServidor
            // 
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServidor.Location = new System.Drawing.Point(150, 6);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(167, 22);
            this.txtServidor.TabIndex = 0;
            // 
            // txtLocal
            // 
            this.txtLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocal.Location = new System.Drawing.Point(150, 37);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(301, 22);
            this.txtLocal.TabIndex = 1;
            // 
            // txtBcoDados
            // 
            this.txtBcoDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBcoDados.Location = new System.Drawing.Point(150, 68);
            this.txtBcoDados.Name = "txtBcoDados";
            this.txtBcoDados.Size = new System.Drawing.Size(263, 22);
            this.txtBcoDados.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Location = new System.Drawing.Point(581, 39);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(167, 22);
            this.txtLogin.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(581, 68);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(167, 25);
            this.txtSenha.TabIndex = 5;
            // 
            // txtPorta
            // 
            this.txtPorta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorta.Location = new System.Drawing.Point(581, 8);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(64, 22);
            this.txtPorta.TabIndex = 3;
            this.txtPorta.Text = "3050";
            this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorta.TextChanged += new System.EventHandler(this.txtPorta_TextChanged);
            // 
            // barraProcesso
            // 
            this.barraProcesso.Location = new System.Drawing.Point(10, 12);
            this.barraProcesso.Name = "barraProcesso";
            this.barraProcesso.Size = new System.Drawing.Size(330, 20);
            this.barraProcesso.TabIndex = 20;
            // 
            // lblProcessando
            // 
            this.lblProcessando.Location = new System.Drawing.Point(10, 35);
            this.lblProcessando.Name = "lblProcessando";
            this.lblProcessando.Size = new System.Drawing.Size(330, 49);
            this.lblProcessando.TabIndex = 21;
            this.lblProcessando.Text = "Processo";
            this.lblProcessando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProcssando
            // 
            this.pnlProcssando.BackColor = System.Drawing.Color.White;
            this.pnlProcssando.Controls.Add(this.lblProcessando);
            this.pnlProcssando.Controls.Add(this.barraProcesso);
            this.pnlProcssando.Location = new System.Drawing.Point(788, 8);
            this.pnlProcssando.Name = "pnlProcssando";
            this.pnlProcssando.Size = new System.Drawing.Size(356, 101);
            this.pnlProcssando.TabIndex = 19;
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.White;
            this.pnlDados.Controls.Add(this.txtSenha);
            this.pnlDados.Controls.Add(this.button1);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txtPorta);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.txtLogin);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.txtBcoDados);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.txtLocal);
            this.pnlDados.Controls.Add(this.label6);
            this.pnlDados.Controls.Add(this.txtServidor);
            this.pnlDados.Location = new System.Drawing.Point(5, 8);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(779, 101);
            this.pnlDados.TabIndex = 19;
            // 
            // bntSalvar
            // 
            this.bntSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvar.Image = global::BancoDeDados.Properties.Resources.play_32;
            this.bntSalvar.Location = new System.Drawing.Point(878, 527);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(120, 80);
            this.bntSalvar.TabIndex = 18;
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::BancoDeDados.Properties.Resources.porta2;
            this.btnSair.Location = new System.Drawing.Point(1018, 527);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 80);
            this.btnSair.TabIndex = 17;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::BancoDeDados.Properties.Resources.pasta;
            this.button1.Location = new System.Drawing.Point(456, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 19;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstProcesso
            // 
            this.lstProcesso.BackColor = System.Drawing.SystemColors.Control;
            this.lstProcesso.FormattingEnabled = true;
            this.lstProcesso.Location = new System.Drawing.Point(12, 123);
            this.lstProcesso.Name = "lstProcesso";
            this.lstProcesso.Size = new System.Drawing.Size(1126, 394);
            this.lstProcesso.TabIndex = 19;
            // 
            // frmManutencaoBcoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 615);
            this.Controls.Add(this.lstProcesso);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManutencaoBcoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Banco de Dados";
            this.Load += new System.EventHandler(this.frmManutencaoBcoDados_Load);
            this.panel1.ResumeLayout(false);
            this.pnlProcssando.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBcoDados;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlProcssando;
        private System.Windows.Forms.Label lblProcessando;
        private System.Windows.Forms.ProgressBar barraProcesso;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ListBox lstProcesso;
    }
}