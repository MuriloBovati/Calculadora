using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal valor1 = 0, valor2 = 0;
        private string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Botao 1
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Botao 1
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Botao 2
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Botao 3
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Botao 4
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Botao 5
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Botao 6
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botao 7
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botao 8
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botao 9
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Botao .
            txtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Botao +
            valor1 = inputTreatment(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Botao -
            valor1 = inputTreatment(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Botao X
            valor1 = inputTreatment(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "X";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Botao /
            valor1 = inputTreatment(txtResultado.Text);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao CE
            valor1 = 0;
            valor2 = 0;
            txtResultado.Text = "";
            operacao = "";
            lblOperacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Botao C
            valor1 = 0;
            txtResultado.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Botao =

            valor2 = inputTreatment(txtResultado.Text);

            switch(operacao)
            {
                case "SOMA":
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                    break;

                case "SUB":
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                    break;

                case "MULT":
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                    break;

                case "DIV":
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                    break;
            }
        }

        private decimal inputTreatment(string textInput)
        {
            decimal result;
            try
            {
                result = decimal.Parse(textInput, CultureInfo.InvariantCulture);
                return result;
            }
            catch
            {
                return result = 0;
            }
        }

    }
}
