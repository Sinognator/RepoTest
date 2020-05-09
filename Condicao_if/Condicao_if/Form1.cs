using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double idade = Convert.ToDouble(txtIdade.Text);

            if(idade > 17)
            {
                MessageBox.Show("Você ainda é MAIOR de idade", "Mensagem");
                txtIdade.Text = "";
            }
            else
            {
                MessageBox.Show("Você ainda é MENOR de idade", "Mensagem");
                txtIdade.Text = "";
            }
        }
    }
}
