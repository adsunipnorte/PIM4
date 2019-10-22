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
    public partial class FrmTpVeiculo : Form
    {
        public FrmTpVeiculo()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpVeiculo novotpveiculo = new FrmCadTpVeiculo();
            novotpveiculo.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpVeiculo altveiculo = new FrmCadTpVeiculo();
            altveiculo.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadTpVeiculo novotpveiculo = new FrmCadTpVeiculo();
            novotpveiculo.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadTpVeiculo altveiculo = new FrmCadTpVeiculo();
            altveiculo.Show();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }


            else if (rdbdescricao.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando pelo texto contido no textbox
            {


                txtpesquisar.Focus(); // Foco é colocado em textbox

                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_tipoveiculo.id, tb_tipoveiculo.descricao, tb_situacao.id from tb_tipoveiculo left join tb_situacao on tb_situacao.id=tb_tipoveiculo.situacao where upper(descricao) like '%" + txtpesquisar.Text + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvtpveiculo.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbsituacao.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_tipoveiculo.id, tb_tipoveiculo.descricao, tb_situacao.id from tb_tipoveiculo left join tb_situacao on tb_situacao.id=tb_tipoveiculo.situacao where upper(situacao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvtpveiculo.DataSource = dt;
                txtpesquisar.Focus();

            }
        }
    }
}
