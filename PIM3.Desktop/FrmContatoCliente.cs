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
    public partial class FrmContatoCliente : Form
    {
        public FrmContatoCliente()
        {
            InitializeComponent();
        }


        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadContatoCliente novocontatocliente = new FrmCadContatoCliente();
            novocontatocliente.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadContatoCliente altcontatocliente = new FrmCadContatoCliente();
            altcontatocliente.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadContatoCliente novocontatocliente = new FrmCadContatoCliente();
            novocontatocliente.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadContatoCliente altcontatocliente = new FrmCadContatoCliente();
            altcontatocliente.Show();
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

        private void FrmContatoCliente_KeyDown(object sender, KeyEventArgs e)
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

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "") // Verifica se o textbox ou maskedtextbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }


            else if (rdbnome.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no maskedtextbox
            {



                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_contatos.id, tb_contatos.nome, tb_contatos.email, tb_clientes.fantasia as Cliente  from tb_contatos inner join tb_clientes on tb_clientes.id=tb_contatos.idclientes where upper(tb_contatos.nome) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvcontatocliente.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbcliente.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_contatos.id, tb_contatos.nome, tb_contatos.email, tb_clientes.fantasia as Cliente  from tb_contatos inner join tb_clientes on tb_clientes.id=tb_contatos.idclientes where upper(tb_clientes.fantasia) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcontatocliente.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbnome.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {

                txtpesquisar.TextName = "";
                txtpesquisar.Focus();

            }
        }

        private void rdbcliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbcliente.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar

            }
        }
    }
}
