using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjExemploRadCheck
{
    public partial class frmExemplo : Form
    {
       
        public frmExemplo()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            String lista = "";
            if (chkMusica.Checked==true)
            {
                lista = lista + "Música ";
            }
            if (chkDanca.Checked==true)
            {
                lista = lista + "Dança ";
            }
            if (chkLeitura.Checked==true)
            {
                lista = lista + "Leitura ";
            }


            if (radMasculino.Checked == true)
            {
                MessageBox.Show("Boa Noite Sr." + txtNome.Text + "!!!\n\nSua(s) preferência(s) são: " + lista+"\n\n");
            }
            else
                if (radFeminino.Checked == true)
                {
                    MessageBox.Show("Boa Noite Sra." + txtNome.Text + "!!!\n\nSua(s) preferência(s) são: " + lista + "\n\n");
                }
                else
                {
                    MessageBox.Show("Selecione o sexo !!!");
                }
              
        }
    }
}
