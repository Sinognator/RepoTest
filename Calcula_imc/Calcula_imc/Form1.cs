using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = txtPeso.Text = txtImc.Text = "";

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPeso.Text);

            double imc = peso / (altura * altura);

            txtImc.Text = imc.ToString();

            if(imc < 18.5)
            {
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(imc < 25){
                MessageBox.Show("SITUAÇÃO: Você está com peso dentro da normalidade.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 30)
            {
                MessageBox.Show("SITUAÇÃO: Você está acima do peso.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 35)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau I", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 40)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau II (severa).", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc >= 40)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau III (mórbida).", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
