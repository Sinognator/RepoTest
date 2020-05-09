using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swith_case
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "DOMINGO":
                    MessageBox.Show("Você escolheu DOMINGO que é o 1º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "SEGUNDA":
                    MessageBox.Show("Você escolheu SEGUNDA que é o 2º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "TERÇA":
                    MessageBox.Show("Você escolheu TERÇA que é o 3º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "QUARTA":
                    MessageBox.Show("Você escolheu QUARTA que é o 4º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "QUINTA":
                    MessageBox.Show("Você escolheu QUINTA que é o 5º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "SEXTA":
                    MessageBox.Show("Você escolheu SEXTA que é o 6º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "SÁBADO":
                    MessageBox.Show("Você escolheu SÁBADO que é o 7º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;


            }
        }
    }
}
