namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listIngredientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_farinha = new System.Windows.Forms.Label();
            this.lbl_ovos = new System.Windows.Forms.Label();
            this.lbl_leite = new System.Windows.Forms.Label();
            this.picOvos = new System.Windows.Forms.PictureBox();
            this.picFarinha = new System.Windows.Forms.PictureBox();
            this.picLeite = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picImgCapital = new System.Windows.Forms.PictureBox();
            this.picBandeira = new System.Windows.Forms.PictureBox();
            this.lblDadosDoEstado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbListaDeEstados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOvos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeite)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // listIngredientes
            // 
            this.listIngredientes.FormattingEnabled = true;
            this.listIngredientes.Items.AddRange(new object[] {
            "Leite",
            "Ovos",
            "Farinha"});
            this.listIngredientes.Location = new System.Drawing.Point(6, 32);
            this.listIngredientes.Name = "listIngredientes";
            this.listIngredientes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listIngredientes.Size = new System.Drawing.Size(129, 56);
            this.listIngredientes.TabIndex = 0;
            this.listIngredientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_farinha);
            this.groupBox1.Controls.Add(this.lbl_ovos);
            this.groupBox1.Controls.Add(this.lbl_leite);
            this.groupBox1.Controls.Add(this.picOvos);
            this.groupBox1.Controls.Add(this.picFarinha);
            this.groupBox1.Controls.Add(this.picLeite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listIngredientes);
            this.groupBox1.Location = new System.Drawing.Point(389, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 498);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receitas";
            // 
            // lbl_farinha
            // 
            this.lbl_farinha.AutoSize = true;
            this.lbl_farinha.Location = new System.Drawing.Point(494, 170);
            this.lbl_farinha.Name = "lbl_farinha";
            this.lbl_farinha.Size = new System.Drawing.Size(10, 13);
            this.lbl_farinha.TabIndex = 8;
            this.lbl_farinha.Text = " ";
            // 
            // lbl_ovos
            // 
            this.lbl_ovos.AutoSize = true;
            this.lbl_ovos.Location = new System.Drawing.Point(254, 170);
            this.lbl_ovos.Name = "lbl_ovos";
            this.lbl_ovos.Size = new System.Drawing.Size(10, 13);
            this.lbl_ovos.TabIndex = 7;
            this.lbl_ovos.Text = " ";
            // 
            // lbl_leite
            // 
            this.lbl_leite.AutoSize = true;
            this.lbl_leite.Location = new System.Drawing.Point(9, 170);
            this.lbl_leite.Name = "lbl_leite";
            this.lbl_leite.Size = new System.Drawing.Size(10, 13);
            this.lbl_leite.TabIndex = 6;
            this.lbl_leite.Text = " ";
            // 
            // picOvos
            // 
            this.picOvos.Location = new System.Drawing.Point(254, 94);
            this.picOvos.Name = "picOvos";
            this.picOvos.Size = new System.Drawing.Size(91, 69);
            this.picOvos.TabIndex = 5;
            this.picOvos.TabStop = false;
            // 
            // picFarinha
            // 
            this.picFarinha.Location = new System.Drawing.Point(494, 94);
            this.picFarinha.Name = "picFarinha";
            this.picFarinha.Size = new System.Drawing.Size(91, 69);
            this.picFarinha.TabIndex = 3;
            this.picFarinha.TabStop = false;
            // 
            // picLeite
            // 
            this.picLeite.Location = new System.Drawing.Point(6, 94);
            this.picLeite.Name = "picLeite";
            this.picLeite.Size = new System.Drawing.Size(91, 69);
            this.picLeite.TabIndex = 2;
            this.picLeite.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione os Ingredientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.picImgCapital);
            this.groupBox2.Controls.Add(this.picBandeira);
            this.groupBox2.Controls.Add(this.lblDadosDoEstado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbListaDeEstados);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 498);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estados";
            // 
            // picImgCapital
            // 
            this.picImgCapital.Location = new System.Drawing.Point(6, 170);
            this.picImgCapital.Name = "picImgCapital";
            this.picImgCapital.Size = new System.Drawing.Size(357, 182);
            this.picImgCapital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImgCapital.TabIndex = 5;
            this.picImgCapital.TabStop = false;
            // 
            // picBandeira
            // 
            this.picBandeira.Location = new System.Drawing.Point(58, 64);
            this.picBandeira.Name = "picBandeira";
            this.picBandeira.Size = new System.Drawing.Size(40, 24);
            this.picBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBandeira.TabIndex = 4;
            this.picBandeira.TabStop = false;
            // 
            // lblDadosDoEstado
            // 
            this.lblDadosDoEstado.AutoSize = true;
            this.lblDadosDoEstado.Location = new System.Drawing.Point(7, 103);
            this.lblDadosDoEstado.Name = "lblDadosDoEstado";
            this.lblDadosDoEstado.Size = new System.Drawing.Size(39, 13);
            this.lblDadosDoEstado.TabIndex = 3;
            this.lblDadosDoEstado.Text = "Capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bandeira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha um estado";
            // 
            // cmbListaDeEstados
            // 
            this.cmbListaDeEstados.FormattingEnabled = true;
            this.cmbListaDeEstados.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cmbListaDeEstados.Location = new System.Drawing.Point(6, 32);
            this.cmbListaDeEstados.Name = "cmbListaDeEstados";
            this.cmbListaDeEstados.Size = new System.Drawing.Size(191, 21);
            this.cmbListaDeEstados.TabIndex = 0;
            this.cmbListaDeEstados.SelectedIndexChanged += new System.EventHandler(this.cmbListaDeEstados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imagem da Capital";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOvos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFarinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeite)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandeira)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listIngredientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_farinha;
        private System.Windows.Forms.Label lbl_ovos;
        private System.Windows.Forms.Label lbl_leite;
        private System.Windows.Forms.PictureBox picOvos;
        private System.Windows.Forms.PictureBox picFarinha;
        private System.Windows.Forms.PictureBox picLeite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDadosDoEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbListaDeEstados;
        private System.Windows.Forms.PictureBox picImgCapital;
        private System.Windows.Forms.PictureBox picBandeira;
        private System.Windows.Forms.Label label4;
    }
}

