using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<double> valueList = new List<double>();
        private void ColectValues()
        {
            valueList.Clear();
            valueList.Add(Double.Parse(input1.Text));
            valueList.Add(Double.Parse(input2.Text));
            valueList.Add(Double.Parse(input3.Text));
            valueList.Sort();
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnMin2Max_Click(object sender, EventArgs e)
        {
            ColectValues();
            out1.Text = valueList[0].ToString();
            out2.Text = valueList[1].ToString();
            out3.Text = valueList[2].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMax2Min_Click(object sender, EventArgs e)
        {
            ColectValues();
            out1.Text = valueList[2].ToString();
            out2.Text = valueList[1].ToString();
            out3.Text = valueList[0].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            out1.Text = "0";
            out2.Text = "0";
            out3.Text = "0";
            input1.Text = " ";
            input2.Text = " ";
            input3.Text = " ";
        }
    }
}
;