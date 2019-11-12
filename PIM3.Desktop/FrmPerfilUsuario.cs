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
    public partial class FrmPerfilUsuario : Form
    {
        public FrmPerfilUsuario()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPerfilUsuario novoperfilusuario = new FrmCadPerfilUsuario();
            novoperfilusuario.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPerfilUsuario altperfilusuario = new FrmCadPerfilUsuario();
            altperfilusuario.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void rdbsituacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbsituacao.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {

                txtpesquisar.TextName = ""; // Limpa textbox
                txtpesquisar.Focus(); // Foco no textbox

            }
        }

        private void rdbdescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdescricao.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no textbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "") // Verifica se o textbox ou maskedtextbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }


            else if (rdbdescricao.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no maskedtextbox
            {


                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_perfilusuarios.id, tb_perfilusuarios.descricao as DESCRICAO, tb_situacao.descricao as SITUACAO from tb_perfilusuarios inner join tb_situacao on tb_situacao.id=tb_perfilusuarios.situacao where upper(tb_perfilusuarios.descricao)  like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvperfilusuarios.DataSource = dt;
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
                string Query = "select tb_perfilusuarios.id, tb_perfilusuarios.descricao as DESCRICAO, tb_situacao.descricao as SITUACAO from tb_perfilusuarios inner join tb_situacao on tb_situacao.id=tb_perfilusuarios.situacao where upper(tb_situacao.descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvperfilusuarios.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void FrmPerfilUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }

                else
                {
                    txtpesquisar.Focus();
                }
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadPerfilUsuario perfiluser = new FrmCadPerfilUsuario();
            perfiluser.Show();
        }
    }
}
