using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Banco_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();

            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                
                con.Open();
                //Criando Sql Command, Selecionando todos os dados na tb_clientes;
                MySqlCommand Cmm = new MySqlCommand();
                Cmm.CommandText = "SELECT * FROM tb_clientes";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con;
                MySqlDataReader DR;
                DR = Cmm.ExecuteReader();
                /*Carregar dados do DataGrid */
                DataTable dt = new DataTable();
                dt.Load(DR);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                con.Close();

                MessageBox.Show("A conexão foi realizada com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(String.Format("Falha na Conexão: {0}", ex.Message));

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
