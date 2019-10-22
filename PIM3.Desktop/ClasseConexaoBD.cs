﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLComando;
using System.Windows.Forms;
using System.Data;

namespace PIM3.Desktop
{
    public class ClasseConexaoBD //Classe para conectar ao banco de dados
    {

        public void AbreConexao(string AbreBD) // Método que abre conexão com banco de dados com parâmetro
        {

            string conectaBD = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True"; // Variável que recebe a string de conexão
            string queryAbreBD = AbreBD;                           // Váriavel que recebe parâmetro criado na classe
            SqlConnection conexao = new SqlConnection(conectaBD);  // Variável de conexão com parâmetro de string de conexão
            SqlCommand comandosql = new SqlCommand(queryAbreBD, conexao); // Variável de conexão com dois parâmetros (string que recebeu parâmetro do método e variável com string de conexão)

            try             // Início Try/Catch
            {
                conexao.Open(); // Variável do tipo SqlConnection com método Open
                comandosql.ExecuteNonQuery(); // Variável do tipo SqlCommand com método ExecuteNoQuery
                //alert.Show("Registro inserido com sucesso.", alert.AlertType.success);
            }
            catch (Exception excecao)
            {

                string erro = excecao.Message;
                erro += "Não foi possivel conectar ao banco de dados.";
                //alert.Show("Não foi possivel conectar ao banco de dados.", alert.AlertType.error);

            }

            
        }

        //private void login()
        //{
        //    string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
        //    //cria a conexão
        //    SqlConnection com = new SqlConnection(strConxao);

        //    //cria a instrução de consulta ao banco
        //    string query = "select login, senha from tb_usuarios where login = '" + txtusuario.TextName + "' and senha = '" + txtsenha.TextName + "'";

        //    //cria o objeto command
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, com);

        //    //instancia o dataset
        //    DataSet ds = new DataSet();

        //    //preenche o dataset
        //    adapter.Fill(ds, "a");

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        FrmPrincipal menu = new FrmPrincipal();
        //        menu.Show();
                
        //    }
        //    else
        //    {
        //        MessageBox.Show("Login/Senha inválido");

        //    }
        //}


    }
}


