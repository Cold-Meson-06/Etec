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
            resetUserInterface();   //Inicializa a interface com os valores corretos
        }

        //Valores usados nas operações
        private string side1StringValue = "0";
        private string side2StringValue = "0";
        private string side3StringValue = "0";
        private double side1NumericValue = 0;
        private double side2NumericValue = 0;
        private double side3NumericValue = 0;

        //Define se os calculos de perimetro seão executados dinamicamente
        private bool dynamicMode = false;

        //Verifica se os três campos tem valores validos 
        //Exibe as informações propias se tiver erros
        private bool validateUserInput()
        {
            if (!Double.TryParse(side1StringValue, out side1NumericValue))
            {
                MessageBox.Show("O valor do 1º lado não é um número.");
                txtIn1.Focus();
                return false;
            }
            if (!Double.TryParse(side2StringValue, out side2NumericValue))
            {
                MessageBox.Show("O valor do 2º lado não é um número.");
                txtIn2.Focus();
                return false;
            }
            if (!Double.TryParse(side3StringValue, out side3NumericValue))
            {
                MessageBox.Show("O valor do 3º lado não é um número.");
                txtIn3.Focus();
                return false;
            }
            if (side1NumericValue <= 0)
            {
                MessageBox.Show("O valor do 1º lado não pode ser negativo ou zero.");
                txtIn1.Focus();
                return false;
            }
            if (side2NumericValue <= 0)
            {
                MessageBox.Show("O valor do 2º lado não pode ser negativo ou zero.");
                txtIn2.Focus();
                return false;
            }
            if (side3NumericValue <= 0)
            {
                MessageBox.Show("O valor do 3º lado não pode ser negativo ou zero.");
                txtIn3.Focus();
                return false;
            }
            return true;
        }

        //Diz o tipo do triangulo
        //Troca a imagem da `picBoxImageOutput` e o texto da `lblTrigType`
        private void evalTriangleType()
        {
            //Na primeira parte checamos se a imagem deverá ser a `trigInv`
            if (side1NumericValue <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }
            if (side2NumericValue <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }
            if (side3NumericValue <= 0)
            {
                lblTrigType.Text = "Invalido";
                picBoxImageOutput.Image = Properties.Resources.trigInv;
                return ;
            }

            //Se o triangulo é valido, de qual tipo é
            bool allSidesAreEqual = side1NumericValue == side2NumericValue && side1NumericValue == side3NumericValue && side2NumericValue == side3NumericValue;
            if (allSidesAreEqual)
            {
                lblTrigType.Text = "Equilatero";
                picBoxImageOutput.Image = Properties.Resources.trigEqu;
                return;
            }
            bool twoSidesAreEqual = side1NumericValue == side2NumericValue || side1NumericValue == side3NumericValue || side2NumericValue == side3NumericValue;
            if (twoSidesAreEqual)
            {
                lblTrigType.Text = "Isóceles";
                picBoxImageOutput.Image = Properties.Resources.trigIso;
                return;
            }
            bool noSidesAreEqual = side1NumericValue != side2NumericValue && side1NumericValue != side3NumericValue && side2NumericValue != side3NumericValue;
            if (noSidesAreEqual)
            {
                lblTrigType.Text = "Escaleno";
                picBoxImageOutput.Image = Properties.Resources.trigEsc;
                return;
            }

        }   
        
        //Checa se os lados do triangulo são validos e formão um triangulo
        //Retorna m boleano dependendo do resultado
        private bool validateSides(bool quickMode)
        {
            //Criar uma lista facilita as operações;
            //TODO: fazer a lista global para poupar memoria
            List<double> numbersToCompare = new List<double>();
            numbersToCompare.Add(side1NumericValue);
            numbersToCompare.Add(side2NumericValue);
            numbersToCompare.Add(side3NumericValue);

            bool validTriangle = true;
            
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
                            if (validTriangle && numbersToCompare[x] >= numbersToCompare[y] + numbersToCompare[z])
                            {
                                validTriangle = false;
                                //break outerLoop;  //nem isso
                                break;
                            }        
                        }
                    }
                }
            }
                
            //O triangulo não é valido
            if (!validTriangle)
            {
                lblTrigType.Text = "Nenhum";
                lblTrigPerim.Text = "0";
                picBoxImageOutput.Image = Properties.Resources.trigInv;

                //Como essa função pode ser chamada durante o dynamicMode
                //É melhor não mostrar `MessageBox`es
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
        void setTrianglePerimter()
        {
            double triaglePerimter = side1NumericValue + side2NumericValue + side3NumericValue;
            lblTrigPerim.Text = triaglePerimter.ToString();
        }

        //Emite erros que não são emitidos no DynamicMode
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!validateUserInput())
            {
                return;
            }
            if (!validateSides(false))
            {
                return;
            }

            //Se chegarmos a este ponto o triangulo é valido
            evalTriangleType();
            setTrianglePerimter();
            
        }

        //Recebe uma caixa de texto, troca a cor dela baseado em se seu valor é um numero
        //Retorna 0 se o valor é invalido ou um double se for valido
        private double validateTextBox(TextBox input)
        {
            double result = 0;
            if (Double.TryParse(input.Text, out result))
            {
                if (dynamicMode)
                {
                    input.BackColor = Color.White;
                }
                return result;
            }
            else
            {
                if (dynamicMode)
                {
                    input.BackColor = Color.IndianRed;
                }
                return 0;
            }

        }
        //Shorthand para ser usada nos handlers dos `TextBox`
        private void preEval()
        {
            evalTriangleType();
            setTrianglePerimter();
            validateSides(true);

        }

        //handlers para os `TextBox`
        private void txtIn1_TextChanged(object sender, EventArgs e)
        {
            side1NumericValue = validateTextBox(txtIn1);
            side1StringValue = txtIn1.Text;
            if (dynamicMode)
            {
                preEval();
            }
        }

        private void txtIn2_TextChanged(object sender, EventArgs e)
        {
            side2NumericValue = validateTextBox(txtIn2);
            side2StringValue = txtIn2.Text;
            if (dynamicMode)
            {
                preEval();
            }
        }

        private void txtIn3_TextChanged(object sender, EventArgs e)
        {
            side3NumericValue = validateTextBox(txtIn3);
            side3StringValue = txtIn3.Text;
            if (dynamicMode)
            {
                preEval();
            }
        }
       
        //Limpa a tela
        private void resetUserInterface()
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
        
        //Apenas Executa `resetUserInterface`
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            resetUserInterface();
        }

        //Seta o `dynamicMode` para `false`
        private void radBtnWithBtnPress_CheckedChanged(object sender, EventArgs e)
        {
            dynamicMode = !radBtnWithBtnPress.Checked;
            txtIn1.BackColor = Color.White;
            txtIn2.BackColor = Color.White;
            txtIn3.BackColor = Color.White;
        }
        
        //Seta o `dynamicMode` para `true`
        private void radBtnAllways_CheckedChanged(object sender, EventArgs e)
        {
            dynamicMode = radBtnAllways.Checked;
            validateTextBox(txtIn1);
            validateTextBox(txtIn2);
            validateTextBox(txtIn3);
            preEval();
        }
    }
}
