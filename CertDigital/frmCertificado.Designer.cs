namespace CertDigital
{
    partial class frmCertificado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblValidade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThumbprint = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.opfile = new System.Windows.Forms.OpenFileDialog();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCertificado = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkRepositorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 2;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkRepositorio.Checked = true;
            this.chkRepositorio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepositorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRepositorio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRepositorio.Location = new System.Drawing.Point(175, 51);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(170, 24);
            this.chkRepositorio.TabIndex = 2;
            this.chkRepositorio.Text = "Repositório Windows";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Certificado Digital";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.lblValidade);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblSerialNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblThumbprint);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 223);
            this.panel2.TabIndex = 3;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(3, 178);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(18, 20);
            this.lblValidade.TabIndex = 11;
            this.lblValidade.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Validade";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(3, 100);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(18, 20);
            this.lblSerialNumber.TabIndex = 9;
            this.lblSerialNumber.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Serial Number";
            // 
            // lblThumbprint
            // 
            this.lblThumbprint.AutoSize = true;
            this.lblThumbprint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThumbprint.Location = new System.Drawing.Point(3, 33);
            this.lblThumbprint.Name = "lblThumbprint";
            this.lblThumbprint.Size = new System.Drawing.Size(18, 20);
            this.lblThumbprint.TabIndex = 7;
            this.lblThumbprint.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thumbprint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Certificado Digital:";
            // 
            // lblCertificado
            // 
            this.lblCertificado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificado.Location = new System.Drawing.Point(12, 109);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(640, 89);
            this.lblCertificado.TabIndex = 5;
            this.lblCertificado.Text = "...";
            this.lblCertificado.Click += new System.EventHandler(this.lblCertificado_Click);
            // 
            // opfile
            // 
            this.opfile.FileName = "openFileDialog1";
            // 
            // bntSalvar
            // 
            this.bntSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalvar.Image = global::CertDigital.Properties.Resources.save_32;
            this.bntSalvar.Location = new System.Drawing.Point(668, 260);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(120, 80);
            this.bntSalvar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bntSalvar, "Salvar Dados do Certificado Selecionado");
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CertDigital.Properties.Resources.certificado256;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCertificado
            // 
            this.btnCertificado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCertificado.Image = global::CertDigital.Properties.Resources.certificado32;
            this.btnCertificado.Location = new System.Drawing.Point(670, 163);
            this.btnCertificado.Name = "btnCertificado";
            this.btnCertificado.Size = new System.Drawing.Size(120, 80);
            this.btnCertificado.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCertificado, "Selecionar um Certificado Digital");
            this.btnCertificado.UseVisualStyleBackColor = true;
            this.btnCertificado.Click += new System.EventHandler(this.btnCertificado_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::CertDigital.Properties.Resources.porta2;
            this.btnSair.Location = new System.Drawing.Point(670, 356);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 80);
            this.btnSair.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.lblCertificado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCertificado);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificado Digital";
            this.Load += new System.EventHandler(this.frmCertificado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCertificado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThumbprint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog opfile;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}