using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_basicos
{
    public partial class Form1 : Form
    {
        private double ValidaValor(TextBox valor)
        {
            if (valor.Text.Equals("")){
                return 0;
            }
            else
            {
                return Convert.ToDouble(valor.Text);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = ValidaValor(txtNum1);
            num2 = ValidaValor(txtNum2);

            resultado = num1 + num2;

            txtReultado.Text = resultado.ToString();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtReultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = ValidaValor(txtNum1);
            num2 = ValidaValor(txtNum2);

            resultado = num1 - num2;

            txtReultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = ValidaValor(txtNum1);
            num2 = ValidaValor(txtNum2);

            resultado = num1 * num2;

            txtReultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = ValidaValor(txtNum1);
            num2 = ValidaValor(txtNum2);

            resultado = num1 / num2;

            txtReultado.Text = resultado.ToString();
        }
    }
}
