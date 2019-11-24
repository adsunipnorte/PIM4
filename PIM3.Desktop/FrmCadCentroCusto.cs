using DLLComando;
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
using PIM3.Desktop;


namespace PIM3.Desktop
{
    public partial class FrmCadCentroCusto : Form
    {
        public FrmCadCentroCusto()
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
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void FrmCadCentroCusto_Load(object sender, EventArgs e)
        {

        }

        private void chksituacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnerro_Click(object sender, EventArgs e)
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

        private void btnsucesso_Click(object sender, EventArgs e)
        {
            //string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            //string Query = "INSERT INTO tb_centrocustos(descricao)VALUES('" + txtdescricao.Text + "'" + ")";
            //SqlConnection con = new SqlConnection(strConxao);
            //SqlCommand sqlCommand = new SqlCommand(Query, con);

            //con.Open();

            //sqlCommand.ExecuteNonQuery();

            //con.Close();

            // --------------------------------------------------------------------------------------------------------------------
            //ClasseConexaoBD CLASSE = new ClasseConexaoBD(); // VARIÁVEL DO TIPO DA CLASSE DE CONEXÃO
            //string QUERY = "INSERT INTO TB_CENTROCUSTOS(DESCRICAO)VALUES('" + txtdescricao.Text + "'" + ")"; // VARIÁVEL QUE RECEBE COMANDO SQL
            //CLASSE.AbreConexao(QUERY); // VARIÁVEL DO TIPO DA CLASSE DE CONEXÃO COM MÉTODO DE CONEXÃO E VARIÁVEL PASSADA COMO PARÂMETRO

            // --------------------------------------------------------------------------------------------------------------------

            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher o campo descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }

            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_centrocustos(descricao)VALUES('" + txtdescricao.Text.ToUpper() + "'" + ")"; // Variável que recebe comando SQL
                con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
                
                
            }


            // --------------------------------------------------------------------------------------------------------------------


            // --------------------------------------------------------------------------------------------------------------------
            //SqlComandosDLL sql = new SqlComandosDLL();
            //sql.InsertCentroCusto(txtdescricao.Text);
            //alert.Show("Registro inserido com sucesso.", alert.AlertType.success);
            // --------------------------------------------------------------------------------------------------------------------


        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            
            txtdescricao.Clear();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

       
    }
}
