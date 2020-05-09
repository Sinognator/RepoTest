using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_media
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNota1.Text);
            double n2 = Convert.ToDouble(txtNota2.Text);
            double n3 = Convert.ToDouble(txtNota3.Text);

            double res = (n1 + n2 + n3) / 3;

            txtMedia.Text = res.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Text = txtNota2.Text = txtNota3.Text = txtMedia.Text = "";
        }
    }
}
