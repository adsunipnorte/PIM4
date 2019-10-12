using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DLLBD
{
    public class ConectaBDDLL
    {
        public void ConectaBD(string AbreBD) // Método que abre conexão com banco de dados com parâmetro
        {

            string conexao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True"; // Variável que recebe a string de conexão
            string queryparam = AbreBD;                           // Váriavel que recebe parâmetro criado na classe
            SqlConnection sqlconn = new SqlConnection(conexao);  // Variável de conexão com parâmetro de string de conexão
            SqlCommand sqlcomm = new SqlCommand(queryparam, sqlconn); // Variável de conexão com dois parâmetros (string que recebeu parâmetro do método e variável com string de conexão)

            try             // Início Try/Catch
            {
                sqlconn.Open(); // Variável do tipo SqlConnection com método Open
                sqlcomm.ExecuteNonQuery(); // Variável do tipo SqlCommand com método ExecuteNoQuery
            }
            catch (Exception excecao)
            {

                string erro = excecao.Message;
                erro += "Não foi possivel conectar ao banco de dados.";
            }

            finally
            {
                sqlconn.Close();
            }
        }
    }
}
