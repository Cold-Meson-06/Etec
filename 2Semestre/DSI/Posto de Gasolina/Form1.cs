using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    
    public partial class Form1 : Form
    {
        //Values used in the calculations.
        private const double AlcoolPrice = 1.89;
        private const double GasolinePrice = 2.55;
        private const double DisselPrice = 1.89;
        private const double GNVPrice = 1.55;

        private const double oilChange = 59.90;
        private const double sampleWash = 15.0;
        private const double completeWash = 25.0;
        public Form1()
        {
            InitializeComponent();  //Do wathever you want VS.
            ResetInterface();   //I want consize values.
            double r = 0;
            Console.WriteLine(Double.TryParse("12,1", out r));
            Console.WriteLine(r);
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            //We first will check for erros to save processing:
            if (chkLavCompleta.Checked && chkLavSimples.Checked)
            {
                MessageBox.Show("Escolha apenas um tipo de lavagem");
                chkLavCompleta.Checked = false;
                chkLavSimples.Checked = true; //We want the user to chosse the most expen$$ive one.
                return;
            }

            //After that is safe to allocate these
            double fuelAmount = 0;

            //The fuel amount doesnt needs, to be an valid number if 
            //the user just wants the adictional services
            bool assertFalied = !Double.TryParse(inFuelAmount.Text, out fuelAmount);
            
            //The variable used to hold the total.
            double total = 0;
            
            //The user wants new oil?
            if (chkTrocaOleo.Checked)
            {
                total += oilChange;
            }

            //I could solve this by the onclick function
            //but it generate stack overflow errors and
            //solving this will need too much enginerring 
            //for a sample project.
            if (chkLavCompleta.Checked)
            {
                total += completeWash;
            }
            else if(chkLavSimples.Checked)
            {
                total += sampleWash;
            }


            //Check if we dont selected a fuel type, if yes maybe the
            //user only wants an wash or oil, so we dont need to check the radioButton(s).
            if (radNenhum.Checked)
            {
                //The user dont chosse an fuel type
                //But he digited something?
                if(fuelAmount != 0)
                {
                    MessageBox.Show("Por favor, escolha um tipo de combustivel!.");
                    return;
                }

                //The user neither want fuel
                //nor addictional services
                if (total == 0)
                {
                    //So, why he still using the program?
                    MessageBox.Show("Por favor, escolha pelomenos um serviço!.");
                    return;
                }
            }
            else
            {
                //The user wants fuel
                //But he digited an valid value?
                if (assertFalied)
                {
                    MessageBox.Show("Digite um número valido!");
                    inFuelAmount.Text = "";
                    inFuelAmount.Focus();
                    return;
                }

                //If we reach this point, the number is valid. But can be not usefull.
                if (fuelAmount <= 0)
                {
                    //The user dont know how refueling works...
                    MessageBox.Show("Digite um número positivo!");
                    inFuelAmount.Text = "";
                    inFuelAmount.Focus();
                    return;
                }

                //If we reach this point, the number is valid.
                if (radAlcool.Checked)
                {
                    //Alcool?
                    total += AlcoolPrice * fuelAmount;
                }
                else if (radDissel.Checked)
                {
                    //Dissel?
                    total += DisselPrice * fuelAmount;
                }
                else if (radGasoline.Checked)
                {
                    //Gasoline?
                    total += GasolinePrice * fuelAmount;
                }
                else if (radGNV.Checked)
                {
                    //GNV?
                    total += GNVPrice * fuelAmount;
                }
            }
            MessageBox.Show(String.Format("Total\nR$:{0:n2}. ", total));
            
        }

        //This will solve the problem.
        public void ResetInterface()
        {
            radAlcool.Checked = false;
            radDissel.Checked = false;
            radGasoline.Checked = false;
            radGNV.Checked = false;
            radNenhum.Checked = true;
            inFuelAmount.Text = "";
            chkLavCompleta.Checked = false;
            chkLavSimples.Checked = false;
            chkTrocaOleo.Checked = false;
        }

        //The interface is a complete mess, so:
        private void btnCls_Click(object sender, EventArgs e)
        {
            ResetInterface();
        }

        //Change the image.
        private void radAlcool_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.alcool;
        }

        //I wanted an fade-in effect...
        private void radGasoline_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.gasolina;
        }

        //But fade-in i not found...
        private void radGNV_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.gnv;
        }

        //Visual Studio likes fast changes...
        private void radDissel_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.dissel;
        }
        
        //But i like smooth ones.
        private void radNenhum_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.initial;
        }

        //Everything must change the image.
        private void chkTrocaOleo_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.trocaDeOleo;
        }
        
        //There must be a better way to do this.
        private void chkLavSimples_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.lavagemSimples;
        }

        //Because im starting to like to write C# code.
        private void chkLavCompleta_CheckedChanged(object sender, EventArgs e)
        {
            imageOutput.Image = Properties.Resources.lavagemCompleta;
        }
    }
}
