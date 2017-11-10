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
            this.grpFuelType = new System.Windows.Forms.GroupBox();
            this.radNenhum = new System.Windows.Forms.RadioButton();
            this.radDissel = new System.Windows.Forms.RadioButton();
            this.radGNV = new System.Windows.Forms.RadioButton();
            this.radGasoline = new System.Windows.Forms.RadioButton();
            this.radAlcool = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.inFuelAmount = new System.Windows.Forms.TextBox();
            this.grpAddServices = new System.Windows.Forms.GroupBox();
            this.chkLavCompleta = new System.Windows.Forms.CheckBox();
            this.chkLavSimples = new System.Windows.Forms.CheckBox();
            this.chkTrocaOleo = new System.Windows.Forms.CheckBox();
            this.btnEval = new System.Windows.Forms.Button();
            this.btnCls = new System.Windows.Forms.Button();
            this.imageOutput = new System.Windows.Forms.PictureBox();
            this.grpFuelType.SuspendLayout();
            this.grpAddServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFuelType
            // 
            this.grpFuelType.Controls.Add(this.radNenhum);
            this.grpFuelType.Controls.Add(this.radDissel);
            this.grpFuelType.Controls.Add(this.radGNV);
            this.grpFuelType.Controls.Add(this.radGasoline);
            this.grpFuelType.Controls.Add(this.radAlcool);
            this.grpFuelType.Location = new System.Drawing.Point(13, 13);
            this.grpFuelType.Name = "grpFuelType";
            this.grpFuelType.Size = new System.Drawing.Size(137, 147);
            this.grpFuelType.TabIndex = 0;
            this.grpFuelType.TabStop = false;
            this.grpFuelType.Text = "Tipo de Combustivel";
            // 
            // radNenhum
            // 
            this.radNenhum.AutoSize = true;
            this.radNenhum.Location = new System.Drawing.Point(7, 114);
            this.radNenhum.Name = "radNenhum";
            this.radNenhum.Size = new System.Drawing.Size(65, 17);
            this.radNenhum.TabIndex = 4;
            this.radNenhum.TabStop = true;
            this.radNenhum.Text = "Nenhum";
            this.radNenhum.UseVisualStyleBackColor = true;
            this.radNenhum.CheckedChanged += new System.EventHandler(this.radNenhum_CheckedChanged);
            // 
            // radDissel
            // 
            this.radDissel.AutoSize = true;
            this.radDissel.Location = new System.Drawing.Point(7, 90);
            this.radDissel.Name = "radDissel";
            this.radDissel.Size = new System.Drawing.Size(53, 17);
            this.radDissel.TabIndex = 3;
            this.radDissel.TabStop = true;
            this.radDissel.Text = "Dissel";
            this.radDissel.UseVisualStyleBackColor = true;
            this.radDissel.CheckedChanged += new System.EventHandler(this.radDissel_CheckedChanged);
            // 
            // radGNV
            // 
            this.radGNV.AutoSize = true;
            this.radGNV.Location = new System.Drawing.Point(7, 67);
            this.radGNV.Name = "radGNV";
            this.radGNV.Size = new System.Drawing.Size(48, 17);
            this.radGNV.TabIndex = 2;
            this.radGNV.TabStop = true;
            this.radGNV.Text = "GNV";
            this.radGNV.UseVisualStyleBackColor = true;
            this.radGNV.CheckedChanged += new System.EventHandler(this.radGNV_CheckedChanged);
            // 
            // radGasoline
            // 
            this.radGasoline.AutoSize = true;
            this.radGasoline.Location = new System.Drawing.Point(7, 43);
            this.radGasoline.Name = "radGasoline";
            this.radGasoline.Size = new System.Drawing.Size(66, 17);
            this.radGasoline.TabIndex = 1;
            this.radGasoline.TabStop = true;
            this.radGasoline.Text = "Gasolina";
            this.radGasoline.UseVisualStyleBackColor = true;
            this.radGasoline.CheckedChanged += new System.EventHandler(this.radGasoline_CheckedChanged);
            // 
            // radAlcool
            // 
            this.radAlcool.AutoSize = true;
            this.radAlcool.Location = new System.Drawing.Point(6, 19);
            this.radAlcool.Name = "radAlcool";
            this.radAlcool.Size = new System.Drawing.Size(54, 17);
            this.radAlcool.TabIndex = 0;
            this.radAlcool.TabStop = true;
            this.radAlcool.Text = "Alcool";
            this.radAlcool.UseVisualStyleBackColor = true;
            this.radAlcool.CheckedChanged += new System.EventHandler(this.radAlcool_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de Combustivel";
            // 
            // inFuelAmount
            // 
            this.inFuelAmount.Location = new System.Drawing.Point(157, 30);
            this.inFuelAmount.Name = "inFuelAmount";
            this.inFuelAmount.Size = new System.Drawing.Size(157, 20);
            this.inFuelAmount.TabIndex = 2;
            // 
            // grpAddServices
            // 
            this.grpAddServices.Controls.Add(this.chkLavCompleta);
            this.grpAddServices.Controls.Add(this.chkLavSimples);
            this.grpAddServices.Controls.Add(this.chkTrocaOleo);
            this.grpAddServices.Location = new System.Drawing.Point(13, 166);
            this.grpAddServices.Name = "grpAddServices";
            this.grpAddServices.Size = new System.Drawing.Size(137, 100);
            this.grpAddServices.TabIndex = 3;
            this.grpAddServices.TabStop = false;
            this.grpAddServices.Text = "Servicos Adicionais";
            // 
            // chkLavCompleta
            // 
            this.chkLavCompleta.AutoSize = true;
            this.chkLavCompleta.Location = new System.Drawing.Point(7, 68);
            this.chkLavCompleta.Name = "chkLavCompleta";
            this.chkLavCompleta.Size = new System.Drawing.Size(117, 17);
            this.chkLavCompleta.TabIndex = 2;
            this.chkLavCompleta.Text = "Lavagem Completa";
            this.chkLavCompleta.UseVisualStyleBackColor = true;
            this.chkLavCompleta.CheckedChanged += new System.EventHandler(this.chkLavCompleta_CheckedChanged);
            // 
            // chkLavSimples
            // 
            this.chkLavSimples.AutoSize = true;
            this.chkLavSimples.Location = new System.Drawing.Point(7, 44);
            this.chkLavSimples.Name = "chkLavSimples";
            this.chkLavSimples.Size = new System.Drawing.Size(109, 17);
            this.chkLavSimples.TabIndex = 1;
            this.chkLavSimples.Text = "Lavagem Simples";
            this.chkLavSimples.UseVisualStyleBackColor = true;
            this.chkLavSimples.CheckedChanged += new System.EventHandler(this.chkLavSimples_CheckedChanged);
            // 
            // chkTrocaOleo
            // 
            this.chkTrocaOleo.AutoSize = true;
            this.chkTrocaOleo.Location = new System.Drawing.Point(7, 20);
            this.chkTrocaOleo.Name = "chkTrocaOleo";
            this.chkTrocaOleo.Size = new System.Drawing.Size(92, 17);
            this.chkTrocaOleo.TabIndex = 0;
            this.chkTrocaOleo.Text = "Troca de óleo";
            this.chkTrocaOleo.UseVisualStyleBackColor = true;
            this.chkTrocaOleo.CheckedChanged += new System.EventHandler(this.chkTrocaOleo_CheckedChanged);
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(157, 56);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(75, 23);
            this.btnEval.TabIndex = 4;
            this.btnEval.Text = "Calcular";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // btnCls
            // 
            this.btnCls.Location = new System.Drawing.Point(239, 56);
            this.btnCls.Name = "btnCls";
            this.btnCls.Size = new System.Drawing.Size(75, 23);
            this.btnCls.TabIndex = 5;
            this.btnCls.Text = "Limpar";
            this.btnCls.UseVisualStyleBackColor = true;
            this.btnCls.Click += new System.EventHandler(this.btnCls_Click);
            // 
            // imageOutput
            // 
            this.imageOutput.Image = global::WindowsFormsApplication1.Properties.Resources.initial;
            this.imageOutput.InitialImage = global::WindowsFormsApplication1.Properties.Resources.initial;
            this.imageOutput.Location = new System.Drawing.Point(157, 86);
            this.imageOutput.Name = "imageOutput";
            this.imageOutput.Size = new System.Drawing.Size(157, 180);
            this.imageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageOutput.TabIndex = 6;
            this.imageOutput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 283);
            this.Controls.Add(this.imageOutput);
            this.Controls.Add(this.btnCls);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.grpAddServices);
            this.Controls.Add(this.inFuelAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpFuelType);
            this.Name = "Form1";
            this.Text = "Posto";
            this.grpFuelType.ResumeLayout(false);
            this.grpFuelType.PerformLayout();
            this.grpAddServices.ResumeLayout(false);
            this.grpAddServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuelType;
        private System.Windows.Forms.RadioButton radAlcool;
        private System.Windows.Forms.RadioButton radNenhum;
        private System.Windows.Forms.RadioButton radDissel;
        private System.Windows.Forms.RadioButton radGNV;
        private System.Windows.Forms.RadioButton radGasoline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inFuelAmount;
        private System.Windows.Forms.GroupBox grpAddServices;
        private System.Windows.Forms.CheckBox chkLavCompleta;
        private System.Windows.Forms.CheckBox chkLavSimples;
        private System.Windows.Forms.CheckBox chkTrocaOleo;
        private System.Windows.Forms.Button btnEval;
        private System.Windows.Forms.Button btnCls;
        private System.Windows.Forms.PictureBox imageOutput;
    }
}

