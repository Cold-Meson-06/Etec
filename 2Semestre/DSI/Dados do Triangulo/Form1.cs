using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProvaDSIFERNANDOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resetUI();   //Inicializa a interface com os valores corretos
        }

        //Valores usados nas operações
        private string lado1ValorString = "0";
        private string lado2ValorString = "0";
        private string lado3ValorString = "0";
        private double lado1ValorInt = 0;
        private double lado2ValorInt = 0;
        private double lado3ValorInt = 0;

        //Define se os calculos de perimetro seão executados em tempo real
        private bool modoEstatico = true;

        //Verifica se os três campos tem valores validos 
        //Exibe as informações propias se tiver erros
        private bool validarEntrada()
        {
            if (!Double.TryParse(lado1ValorString, out lado1ValorInt))
            {
                MessageBox.Show("O valor do 1º lado não é um número.");
                txtIn1.Focus();
                return false;
            }
            if (!Double.TryParse(lado2ValorString, out lado2ValorInt))
            {
                MessageBox.Show("O valor do 2º lado não é um número.");
                txtIn2.Focus();
                return false;
            }
            if (!Double.TryParse(lado3ValorString, out lado3ValorInt))
            {
                MessageBox.Show("O valor do 3º lado não é um número.");
                txtIn3.Focus();
                return false;
            }
            if (lado1ValorInt <= 0)
            {
                MessageBox.Show("O valor do 1º lado não pode ser negativo ou zero.");
                txtIn1.Focus();
                return false;
            }
            if (lado2ValorInt <= 0)
            {
                MessageBox.Show("O valor do 2º lado não pode ser negativo ou zero.");
                txtIn2.Focus();
                return false;
            }
            if (lado3ValorInt <= 0)
            {
                MessageBox.Show("O valor do 3º lado não pode ser negativo ou zero.");
                txtIn3.Focus();
                return false;
            }
            return true;
        }
       
        //Diz o tipo do triangulo
        //Troca a imagem e o texto da `lblTrigType`
        private void testarTipoDoTriangulo()
        {
            //Na primeira parte checamos se a imagem deverá ser a `trigInv`
            if (lado1ValorInt <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }
            if (lado2ValorInt <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }
            if (lado3ValorInt <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }

            //Na segunda qual imagem correta.
            bool todosOsLadosSaoIguais = lado1ValorInt == lado2ValorInt && lado1ValorInt == lado3ValorInt && lado2ValorInt == lado3ValorInt;
            if (todosOsLadosSaoIguais)
            {
                lblTrigType.Text = "Equilatero";
                picBoxImageOutput.Image = Properties.Resources.trigEqu;
                return;
            }
            bool doisLadosSaoIguais = lado1ValorInt == lado2ValorInt || lado1ValorInt == lado3ValorInt || lado2ValorInt == lado3ValorInt;
            if (doisLadosSaoIguais)
            {
                lblTrigType.Text = "Isóceles";
                picBoxImageOutput.Image = Properties.Resources.trigIso;
                return;
            }
            bool nenhumLadoEIgual = lado1ValorInt != lado2ValorInt && lado1ValorInt != lado3ValorInt && lado2ValorInt != lado3ValorInt;
            if (nenhumLadoEIgual)
            {
                lblTrigType.Text = "Escaleno";
                picBoxImageOutput.Image = Properties.Resources.trigEsc;
                return;
            }

        }   
        
        //Checa se os lados do triangulo são validos e formão um triangulo
        private bool validarLados(bool quickMode)
        {
            //Criar uma lista facilita as operações;
            List<double> numeros = new List<double>();
            numeros.Add(lado1ValorInt);
            numeros.Add(lado2ValorInt);
            numeros.Add(lado3ValorInt);

            bool trianguloEValido = true;
            
            //isto não funcionou
            //outerLoop: for (int x = 0; x < 3; x++)
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int z = 0; z < 3; z++)
                    { 

                        if (x != y && x != z && y != z)
                        {
                            if (trianguloEValido && numeros[x] >= numeros[y] + numeros[z])
                            {
                                trianguloEValido = false;
                                //break outerLoop;  //nem isso
                                break;
                            }        
                        }
                    }
                }
            }
                
            //O triangulo não é valido
            if (!trianguloEValido)
            {
                lblTrigType.Text = "Nenhum";
                lblTrigPerim.Text = "0";
                picBoxImageOutput.Image = Properties.Resources.trigInv;

                //Como essa função pode ser chamada durante o modoDinamico
                //É melhor não irritar o usuario
                if (!quickMode)
                {
                    MessageBox.Show("Valores digitados não formão um triangulo.");
                    txtIn1.Focus();
                }
                return false;
            }

            return true;
        }
        
        //Troca o texto de `lblTrigPerim`
        void checarPerimetroDoTriangulo()
        {
            double perimetro = lado1ValorInt + lado2ValorInt + lado3ValorInt;
            lblTrigPerim.Text = perimetro.ToString();
        }

        //Emite erros se o modoEstatico está ativo
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool sucess = validarEntrada();
            if (!sucess)
            {
                return;
            }

            sucess = validarLados(false);
            if (!sucess)
            {
                return;
            }

            //Senão faca isso normalmente
            testarTipoDoTriangulo();
            checarPerimetroDoTriangulo();
            
        }

        //Recebe uma caixa de texto, troca a cor dela baseado em se seu valor é um numero
        //Retorna 0 ou um double
        private double validateTextBox(TextBox input)
        {
            double result = 0;
            if (Double.TryParse(input.Text, out result))
            {
                if (!modoEstatico)
                {
                    input.BackColor = Color.White;
                }
                return result;
            }
            else
            {
                if (!modoEstatico)
                {
                    input.BackColor = Color.IndianRed;
                }
                return 0;
            }

        }
        //Shorthand
        private void preEval()
        {
            testarTipoDoTriangulo();
            checarPerimetroDoTriangulo();
            validarLados(true);

        }

        //handlers para os `TextBox`
        private void txtIn1_TextChanged(object sender, EventArgs e)
        {
            lado1ValorInt = validateTextBox(txtIn1);
            lado1ValorString = txtIn1.Text;
            if (!modoEstatico)
            {
                preEval();
            }
        }

        private void txtIn2_TextChanged(object sender, EventArgs e)
        {
            lado2ValorInt = validateTextBox(txtIn2);
            lado2ValorString = txtIn2.Text;
            if (!modoEstatico)
            {
                preEval();
            }
        }

        private void txtIn3_TextChanged(object sender, EventArgs e)
        {
            lado3ValorInt = validateTextBox(txtIn3);
            lado3ValorString = txtIn3.Text;
            if (!modoEstatico)
            {
                preEval();
            }
        }
       
        //Limpa a tela
        private void resetUI()
        {
            txtIn1.BackColor = Color.White;
            txtIn2.BackColor = Color.White;
            txtIn3.BackColor = Color.White;
            txtIn1.Text = "0";
            txtIn2.Text = "0";
            txtIn3.Text = "0";
            lblTrigType.Text = "Nenhum";
            lblTrigPerim.Text = "0";
            picBoxImageOutput.Image = Properties.Resources.trigStrt;
        }
        
        //Apenas Executa `resetUI`
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resetUI();
        }

        //Seta o `modoEstatico` para true
        private void radBtnWithBtnPress_CheckedChanged(object sender, EventArgs e)
        {
            modoEstatico = radBtnWithBtnPress.Checked;
            txtIn1.BackColor = Color.White;
            txtIn2.BackColor = Color.White;
            txtIn3.BackColor = Color.White;
        }
        
        //Seta o `modoEstatico` para false
        private void radBtnAllways_CheckedChanged(object sender, EventArgs e)
        {
            modoEstatico = !radBtnAllways.Checked;
            validateTextBox(txtIn1);
            validateTextBox(txtIn2);
            validateTextBox(txtIn3);
            preEval();
        }
    }
}
