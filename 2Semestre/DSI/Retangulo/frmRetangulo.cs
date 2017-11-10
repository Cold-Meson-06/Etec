using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRetangulo
{
    public partial class frmRetangulo : Form
    {
        public frmRetangulo()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double lado1, lado2;

            if (Double.TryParse(txtLado1.Text,out lado1) == false)
            {
                MessageBox.Show("Digite um número em Lado1.");
                txtLado1.Focus();
            }
            else
            {
                if (Double.TryParse(txtLado2.Text, out lado2) == false)
                {
                    MessageBox.Show("Digite um número em Lado2.");
                    txtLado2.Focus();
                }
                else
                {
                    if (lado1 <=0)
                    {
                        MessageBox.Show("O lado1 deve ser maior que zero.");
                        txtLado1.Focus();
                    }
                    else
                    {
                        if (lado2 <= 0)
                        {
                            MessageBox.Show("O lado2 deve ser maior que zero.");
                            txtLado2.Focus();
                        }
                        else
                        {
                            if (lado1==lado2)
                            {
                                picImagem.Image = Properties.Resources.quadrado;
                            }
                            else
                            {
                                picImagem.Image = Properties.Resources.retangulo;
                            }
                        }
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado1.Text = "";
            txtLado2.Text = "";
            picImagem.Image = null;
            txtLado1.Focus();
        }
    }
}
