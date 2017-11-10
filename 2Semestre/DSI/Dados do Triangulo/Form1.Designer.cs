namespace prjProvaDSIFERNANDOM
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
            this.txtIn1 = new System.Windows.Forms.TextBox();
            this.txtIn2 = new System.Windows.Forms.TextBox();
            this.txtIn3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblTrigTypeLbl = new System.Windows.Forms.Label();
            this.lblTrigType = new System.Windows.Forms.Label();
            this.lblTrigTypePerimLbl = new System.Windows.Forms.Label();
            this.lblTrigPerim = new System.Windows.Forms.Label();
            this.mainPannel = new System.Windows.Forms.Panel();
            this.radBtnWithBtnPress = new System.Windows.Forms.RadioButton();
            this.radBtnAllways = new System.Windows.Forms.RadioButton();
            this.grpBoxIn = new System.Windows.Forms.GroupBox();
            this.grpBoxResult = new System.Windows.Forms.GroupBox();
            this.picBoxImageOutput = new System.Windows.Forms.PictureBox();
            this.mainPannel.SuspendLayout();
            this.grpBoxIn.SuspendLayout();
            this.grpBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIn1
            // 
            this.txtIn1.Location = new System.Drawing.Point(12, 26);
            this.txtIn1.Name = "txtIn1";
            this.txtIn1.Size = new System.Drawing.Size(157, 20);
            this.txtIn1.TabIndex = 0;
            this.txtIn1.Text = "0";
            this.txtIn1.TextChanged += new System.EventHandler(this.txtIn1_TextChanged);
            // 
            // txtIn2
            // 
            this.txtIn2.Location = new System.Drawing.Point(12, 65);
            this.txtIn2.Name = "txtIn2";
            this.txtIn2.Size = new System.Drawing.Size(157, 20);
            this.txtIn2.TabIndex = 1;
            this.txtIn2.Text = "0";
            this.txtIn2.TextChanged += new System.EventHandler(this.txtIn2_TextChanged);
            // 
            // txtIn3
            // 
            this.txtIn3.Location = new System.Drawing.Point(12, 104);
            this.txtIn3.Name = "txtIn3";
            this.txtIn3.Size = new System.Drawing.Size(157, 20);
            this.txtIn3.TabIndex = 2;
            this.txtIn3.Text = "0";
            this.txtIn3.TextChanged += new System.EventHandler(this.txtIn3_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 10);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "1º Lado";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(9, 49);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "2º Lado";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(9, 88);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(44, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "3° Lado";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 131);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(94, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblTrigTypeLbl
            // 
            this.lblTrigTypeLbl.AutoSize = true;
            this.lblTrigTypeLbl.Location = new System.Drawing.Point(6, 188);
            this.lblTrigTypeLbl.Name = "lblTrigTypeLbl";
            this.lblTrigTypeLbl.Size = new System.Drawing.Size(95, 13);
            this.lblTrigTypeLbl.TabIndex = 9;
            this.lblTrigTypeLbl.Text = "Tipo de triangulo:  ";
            // 
            // lblTrigType
            // 
            this.lblTrigType.AutoSize = true;
            this.lblTrigType.Location = new System.Drawing.Point(132, 188);
            this.lblTrigType.Name = "lblTrigType";
            this.lblTrigType.Size = new System.Drawing.Size(47, 13);
            this.lblTrigType.TabIndex = 10;
            this.lblTrigType.Text = "Nenhum";
            // 
            // lblTrigTypePerimLbl
            // 
            this.lblTrigTypePerimLbl.AutoSize = true;
            this.lblTrigTypePerimLbl.Location = new System.Drawing.Point(6, 204);
            this.lblTrigTypePerimLbl.Name = "lblTrigTypePerimLbl";
            this.lblTrigTypePerimLbl.Size = new System.Drawing.Size(120, 13);
            this.lblTrigTypePerimLbl.TabIndex = 11;
            this.lblTrigTypePerimLbl.Text = "Perímetro do triangulo:  ";
            // 
            // lblTrigPerim
            // 
            this.lblTrigPerim.AutoSize = true;
            this.lblTrigPerim.Location = new System.Drawing.Point(132, 204);
            this.lblTrigPerim.Name = "lblTrigPerim";
            this.lblTrigPerim.Size = new System.Drawing.Size(13, 13);
            this.lblTrigPerim.TabIndex = 12;
            this.lblTrigPerim.Text = "0";
            // 
            // mainPannel
            // 
            this.mainPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPannel.Controls.Add(this.radBtnWithBtnPress);
            this.mainPannel.Controls.Add(this.btnLimpar);
            this.mainPannel.Controls.Add(this.radBtnAllways);
            this.mainPannel.Controls.Add(this.txtIn1);
            this.mainPannel.Controls.Add(this.txtIn2);
            this.mainPannel.Controls.Add(this.txtIn3);
            this.mainPannel.Controls.Add(this.lbl1);
            this.mainPannel.Controls.Add(this.lbl2);
            this.mainPannel.Controls.Add(this.lbl3);
            this.mainPannel.Controls.Add(this.btnCalcular);
            this.mainPannel.Location = new System.Drawing.Point(6, 19);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(181, 203);
            this.mainPannel.TabIndex = 13;
            // 
            // radBtnWithBtnPress
            // 
            this.radBtnWithBtnPress.AutoSize = true;
            this.radBtnWithBtnPress.Checked = true;
            this.radBtnWithBtnPress.Location = new System.Drawing.Point(12, 183);
            this.radBtnWithBtnPress.Name = "radBtnWithBtnPress";
            this.radBtnWithBtnPress.Size = new System.Drawing.Size(163, 17);
            this.radBtnWithBtnPress.TabIndex = 15;
            this.radBtnWithBtnPress.TabStop = true;
            this.radBtnWithBtnPress.Text = "Calcular apenas com o botão";
            this.radBtnWithBtnPress.UseVisualStyleBackColor = true;
            this.radBtnWithBtnPress.CheckedChanged += new System.EventHandler(this.radBtnWithBtnPress_CheckedChanged);
            // 
            // radBtnAllways
            // 
            this.radBtnAllways.AutoSize = true;
            this.radBtnAllways.Location = new System.Drawing.Point(12, 160);
            this.radBtnAllways.Name = "radBtnAllways";
            this.radBtnAllways.Size = new System.Drawing.Size(148, 17);
            this.radBtnAllways.TabIndex = 14;
            this.radBtnAllways.Text = "Calcular durante digitação";
            this.radBtnAllways.UseVisualStyleBackColor = true;
            this.radBtnAllways.CheckedChanged += new System.EventHandler(this.radBtnAllways_CheckedChanged);
            // 
            // grpBoxIn
            // 
            this.grpBoxIn.Controls.Add(this.mainPannel);
            this.grpBoxIn.Location = new System.Drawing.Point(10, 12);
            this.grpBoxIn.Name = "grpBoxIn";
            this.grpBoxIn.Size = new System.Drawing.Size(195, 234);
            this.grpBoxIn.TabIndex = 14;
            this.grpBoxIn.TabStop = false;
            this.grpBoxIn.Text = "Entrada";
            // 
            // grpBoxResult
            // 
            this.grpBoxResult.Controls.Add(this.picBoxImageOutput);
            this.grpBoxResult.Controls.Add(this.lblTrigTypeLbl);
            this.grpBoxResult.Controls.Add(this.lblTrigPerim);
            this.grpBoxResult.Controls.Add(this.lblTrigType);
            this.grpBoxResult.Controls.Add(this.lblTrigTypePerimLbl);
            this.grpBoxResult.Location = new System.Drawing.Point(211, 12);
            this.grpBoxResult.Name = "grpBoxResult";
            this.grpBoxResult.Size = new System.Drawing.Size(225, 234);
            this.grpBoxResult.TabIndex = 15;
            this.grpBoxResult.TabStop = false;
            this.grpBoxResult.Text = "Resultado";
            // 
            // picBoxImageOutput
            // 
            this.picBoxImageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImageOutput.Image = global::prjProvaDSIFERNANDOM.Properties.Resources.trigStrt;
            this.picBoxImageOutput.Location = new System.Drawing.Point(6, 25);
            this.picBoxImageOutput.Name = "picBoxImageOutput";
            this.picBoxImageOutput.Size = new System.Drawing.Size(200, 150);
            this.picBoxImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImageOutput.TabIndex = 8;
            this.picBoxImageOutput.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 250);
            this.Controls.Add(this.grpBoxResult);
            this.Controls.Add(this.grpBoxIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPannel.ResumeLayout(false);
            this.mainPannel.PerformLayout();
            this.grpBoxIn.ResumeLayout(false);
            this.grpBoxResult.ResumeLayout(false);
            this.grpBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn1;
        private System.Windows.Forms.TextBox txtIn2;
        private System.Windows.Forms.TextBox txtIn3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox picBoxImageOutput;
        private System.Windows.Forms.Label lblTrigTypeLbl;
        private System.Windows.Forms.Label lblTrigType;
        private System.Windows.Forms.Label lblTrigTypePerimLbl;
        private System.Windows.Forms.Label lblTrigPerim;
        private System.Windows.Forms.Panel mainPannel;
        private System.Windows.Forms.RadioButton radBtnAllways;
        private System.Windows.Forms.RadioButton radBtnWithBtnPress;
        private System.Windows.Forms.GroupBox grpBoxIn;
        private System.Windows.Forms.GroupBox grpBoxResult;
    }
}

