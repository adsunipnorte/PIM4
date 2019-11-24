using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3.Desktop
{
    public partial class FrmCadTpCliente : Form
    {
        public FrmCadTpCliente()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdescricao.Clear();
            txtdescricao.Focus();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher o campo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();

            }

            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_tipocliente(descricao)VALUES('" + txtdescricao.Text.ToUpper() + "'" + ")"; // Variável que recebe comando SQL
                con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
                txtdescricao.Clear();
                txtdescricao.Focus();

            }




            //-------------------------------------------------------------

            //string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            //string Query = "INSERT INTO tb_tipocliente(descricao)VALUES('" + txtdescricao.Text + "'" + ")";
            //SqlConnection con = new SqlConnection(strConxao);
            //SqlCommand sqlCommand = new SqlCommand(Query, con);





            //try             // Início Try/Catch
            //{
            //    con.Open();
            //    sqlCommand.ExecuteNonQuery();
            //    alert.Show("Registro inserido com sucesso.", alert.AlertType.success);



            //}
            //catch (Exception excecao)
            //{

            //    string erro = excecao.Message;
            //    erro += "Não foi possivel conectar ao banco de dados.";
            //    con.Close();
            //    alert.Show("Não foi possivel conectar ao banco de dados.", alert.AlertType.error);
            //}




        }

        //---------


    }
}
