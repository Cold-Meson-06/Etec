namespace prjExemploRadCheck
{
    partial class frmExemplo
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
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkLeitura = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDanca = new System.Windows.Forms.CheckBox();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Location = new System.Drawing.Point(81, 126);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(60, 17);
            this.chkMusica.TabIndex = 3;
            this.chkMusica.Text = "Música";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkLeitura
            // 
            this.chkLeitura.AutoSize = true;
            this.chkLeitura.Location = new System.Drawing.Point(180, 126);
            this.chkLeitura.Name = "chkLeitura";
            this.chkLeitura.Size = new System.Drawing.Size(58, 17);
            this.chkLeitura.TabIndex = 5;
            this.chkLeitura.Text = "Leitura";
            this.chkLeitura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Preferências:";
            // 
            // chkDanca
            // 
            this.chkDanca.AutoSize = true;
            this.chkDanca.Location = new System.Drawing.Point(81, 149);
            this.chkDanca.Name = "chkDanca";
            this.chkDanca.Size = new System.Drawing.Size(58, 17);
            this.chkDanca.TabIndex = 4;
            this.chkDanca.Text = "Dança";
            this.chkDanca.UseVisualStyleBackColor = true;
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.radFeminino);
            this.grbSexo.Controls.Add(this.radMasculino);
            this.grbSexo.Location = new System.Drawing.Point(56, 39);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(251, 39);
            this.grbSexo.TabIndex = 1;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo:";
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(137, 16);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 2;
            this.radFeminino.TabStop = true;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(43, 16);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 1;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(182, 164);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(86, 36);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(320, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 13;
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.chkDanca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLeitura);
            this.Controls.Add(this.chkMusica);
            this.Name = "frmExemplo";
            this.Text = "Exemplo de uso CheckBox e RadioButton";
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkLeitura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDanca;
        private System.Windows.Forms.GroupBox grbSexo;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
    }
}

