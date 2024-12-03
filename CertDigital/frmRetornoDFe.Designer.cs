namespace CertDigital
{
    partial class frmRetornoDFe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pcttriste = new System.Windows.Forms.PictureBox();
            this.pctfeliz = new System.Windows.Forms.PictureBox();
            this.lblCodigoSefaz = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcttriste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctfeliz)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 66);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CertDigital.Properties.Resources.logoCommerceedmAmarelo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1110, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Retorno SEFAZ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcttriste
            // 
            this.pcttriste.Image = global::CertDigital.Properties.Resources.pessoatriste;
            this.pcttriste.Location = new System.Drawing.Point(1008, 81);
            this.pcttriste.Name = "pcttriste";
            this.pcttriste.Size = new System.Drawing.Size(172, 312);
            this.pcttriste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcttriste.TabIndex = 0;
            this.pcttriste.TabStop = false;
            this.pcttriste.Visible = false;
            // 
            // pctfeliz
            // 
            this.pctfeliz.Image = global::CertDigital.Properties.Resources.PessoaFeliz;
            this.pctfeliz.Location = new System.Drawing.Point(982, 81);
            this.pctfeliz.Name = "pctfeliz";
            this.pctfeliz.Size = new System.Drawing.Size(199, 318);
            this.pctfeliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctfeliz.TabIndex = 1;
            this.pctfeliz.TabStop = false;
            // 
            // lblCodigoSefaz
            // 
            this.lblCodigoSefaz.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSefaz.ForeColor = System.Drawing.Color.Yellow;
            this.lblCodigoSefaz.Location = new System.Drawing.Point(16, 80);
            this.lblCodigoSefaz.Name = "lblCodigoSefaz";
            this.lblCodigoSefaz.Size = new System.Drawing.Size(960, 84);
            this.lblCodigoSefaz.TabIndex = 3;
            this.lblCodigoSefaz.Text = "100";
            this.lblCodigoSefaz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Yellow;
            this.lblDescricao.Location = new System.Drawing.Point(16, 169);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(962, 149);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Autorizado o Uso";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDescricao.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Location = new System.Drawing.Point(12, 344);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 55);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK !";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmRetornoDFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(77)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1194, 411);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCodigoSefaz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pctfeliz);
            this.Controls.Add(this.pcttriste);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetornoDFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRetornoDFe";
            this.Load += new System.EventHandler(this.frmRetornoDFe_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcttriste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctfeliz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcttriste;
        private System.Windows.Forms.PictureBox pctfeliz;
        private System.Windows.Forms.Label lblCodigoSefaz;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnOK;
    }
}