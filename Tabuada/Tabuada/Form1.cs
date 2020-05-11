using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabuada.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int cont = 1;

            while(cont <= 10){
                string a = numero + " + " + cont + " = " + (cont + numero);
                lstTabuada.Items.Add(a);
                cont++;
            }

        }
    }
}
