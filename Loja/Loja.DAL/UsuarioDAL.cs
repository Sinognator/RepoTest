using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;
using MySql.Data.MySqlClient;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_usuarios";
                CM.Connection = CON;

                MySqlDataReader ER;
                IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();

                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        usuario_DTO usu = new usuario_DTO();
                        usu.id = Convert.ToInt32(ER["id"]);
                        usu.perfil = Convert.ToInt32(ER["perfil"]);
                        usu.cadastro = Convert.ToDateTime(ER["cadastro"]);
                        usu.nome = Convert.ToString(ER["nome"]);
                        usu.email = Convert.ToString(ER["email"]);
                        usu.login = Convert.ToString(ER["cadastro"]);
                        usu.senha = Convert.ToString(ER["senha"]);
                        usu.situacao = Convert.ToString(ER["situacao"]);
                        listUsuarioDTO.Add(usu);

                    }
                }
                return listUsuarioDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int insereUsuario(usuario_DTO USU)
        {
            try
            {
                /*Conexão com BD
                * Inserindo dados na tb_usuarios*/
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_usuarios (nome, login, email, senha, cadastro, situacao,perfil)" +
            "VALUES (@nome, @login, @email, @senha, @cadastro, @situacao, @perfil)";
                /*Parameters irá substituir os valores dentro do campo */
                CM.Parameters.Add("nome", MySqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("login", MySqlDbType.VarChar).Value = USU.login;
                CM.Parameters.Add("email", MySqlDbType.VarChar).Value = USU.email;
                CM.Parameters.Add("senha", MySqlDbType.VarChar).Value = USU.senha;
                CM.Parameters.Add("cadastro", MySqlDbType.DateTime).Value = USU.cadastro;
                CM.Parameters.Add("situacao", MySqlDbType.VarChar).Value = USU.situacao;
                CM.Parameters.Add("perfil", MySqlDbType.Int32).Value = USU.perfil;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int editaUsuario(usuario_DTO USU)
        {
            try
            {
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_usuarios SET perfil=@perfil," +
                "nome=@nome," + "login=@login," + "email=@email," + "senha=@senha," +
                "cadastro=@cadastro," + "situacao=@situacao" + "WHERE id=@id";
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("perfil", MySqlDbType.Int32).Value = USU.perfil;
                CM.Parameters.Add("nome", MySqlDbType.VarChar).Value = USU.nome;
                CM.Parameters.Add("login", MySqlDbType.VarChar).Value = USU.login;
                CM.Parameters.Add("email", MySqlDbType.VarChar).Value = USU.email;
                CM.Parameters.Add("senha", MySqlDbType.VarChar).Value = USU.senha;
                CM.Parameters.Add("cadastro", MySqlDbType.DateTime).Value = USU.cadastro;
                CM.Parameters.Add("situacao", MySqlDbType.VarChar).Value = USU.situacao;
                CM.Parameters.Add("id", MySqlDbType.VarChar).Value = USU.situacao;
                CM.Connection = CON;
                /*Abre conexão*/
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletaUsuario(usuario_DTO USU)
        {
            try
            {
                /*Excluindo dados na tb_usuarios*/
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_usuarios WHERE id = @id";
                /*Têm um único parâmetro que será o código do usuário, só existe um*/
                CM.Parameters.Add("id", MySqlDbType.Int32).Value = USU.id;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                /*Retorna registros afetados*/
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
