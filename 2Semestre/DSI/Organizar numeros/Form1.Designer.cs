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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.out1 = new System.Windows.Forms.Label();
            this.out2 = new System.Windows.Forms.Label();
            this.out3 = new System.Windows.Forms.Label();
            this.btnMin2Max = new System.Windows.Forms.Button();
            this.btnMax2Min = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(12, 12);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(12, 38);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 1;
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(12, 64);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(100, 20);
            this.input3.TabIndex = 2;
            // 
            // out1
            // 
            this.out1.AutoSize = true;
            this.out1.Location = new System.Drawing.Point(12, 91);
            this.out1.Name = "out1";
            this.out1.Size = new System.Drawing.Size(13, 13);
            this.out1.TabIndex = 3;
            this.out1.Text = "0";
            this.out1.Click += new System.EventHandler(this.label1_Click);
            // 
            // out2
            // 
            this.out2.AutoSize = true;
            this.out2.Location = new System.Drawing.Point(54, 91);
            this.out2.Name = "out2";
            this.out2.Size = new System.Drawing.Size(13, 13);
            this.out2.TabIndex = 4;
            this.out2.Text = "0";
            this.out2.Click += new System.EventHandler(this.label2_Click);
            // 
            // out3
            // 
            this.out3.AutoSize = true;
            this.out3.Location = new System.Drawing.Point(96, 91);
            this.out3.Name = "out3";
            this.out3.Size = new System.Drawing.Size(13, 13);
            this.out3.TabIndex = 5;
            this.out3.Text = "0";
            this.out3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnMin2Max
            // 
            this.btnMin2Max.Location = new System.Drawing.Point(12, 139);
            this.btnMin2Max.Name = "btnMin2Max";
            this.btnMin2Max.Size = new System.Drawing.Size(97, 23);
            this.btnMin2Max.TabIndex = 6;
            this.btnMin2Max.Text = "Crescente";
            this.btnMin2Max.UseVisualStyleBackColor = true;
            this.btnMin2Max.Click += new System.EventHandler(this.btnMin2Max_Click);
            // 
            // btnMax2Min
            // 
            this.btnMax2Min.Location = new System.Drawing.Point(12, 168);
            this.btnMax2Min.Name = "btnMax2Min";
            this.btnMax2Min.Size = new System.Drawing.Size(97, 23);
            this.btnMax2Min.TabIndex = 7;
            this.btnMax2Min.Text = "Decrescente";
            this.btnMax2Min.UseVisualStyleBackColor = true;
            this.btnMax2Min.Click += new System.EventHandler(this.btnMax2Min_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMax2Min);
            this.Controls.Add(this.btnMin2Max);
            this.Controls.Add(this.out3);
            this.Controls.Add(this.out2);
            this.Controls.Add(this.out1);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label out1;
        private System.Windows.Forms.Label out2;
        private System.Windows.Forms.Label out3;
        private System.Windows.Forms.Button btnMin2Max;
        private System.Windows.Forms.Button btnMax2Min;
        private System.Windows.Forms.Button btnClear;
    }
}

