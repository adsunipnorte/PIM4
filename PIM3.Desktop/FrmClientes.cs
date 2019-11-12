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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadCliente cadcliente = new FrmCadCliente();
            cadcliente.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar esta janela?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadCliente altcliente = new FrmCadCliente();
            altcliente.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente novocliente = new FrmCadCliente();
            novocliente.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente altcliente = new FrmCadCliente();
            altcliente.Show();
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
                string Query = "select tb_clientes.id as ID, tb_clientes.Fantasia as Nome, tb_tipocliente.descricao as Tipo_cliente, tb_clientes.email as Email, tb_clientes.telefone as Telefone_fixo, tb_cidades.nome as Cidade from tb_clientes left join tb_tipocliente on tb_tipocliente.id=tb_clientes.idtipocliente left join tb_cidades on tb_cidades.codcidade=tb_clientes.idcodcidade where upper(tb_clientes.fantasia) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvcliente.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbemail.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_clientes.id as ID, tb_clientes.Fantasia as Nome, tb_tipocliente.descricao as Tipo_cliente, tb_clientes.email as Email, tb_clientes.telefone as Telefone_fixo, tb_cidades.nome as Cidade from tb_clientes left join tb_tipocliente on tb_tipocliente.id=tb_clientes.idtipocliente left join tb_cidades on tb_cidades.codcidade=tb_clientes.idcodcidade where upper(tb_clientes.email) like '%" + Convert.ToString(txtpesquisar.TextName) + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcliente.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbnome.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {
                            
                txtpesquisar.TextName=""; // Limpa maskedtextbox
                txtpesquisar.Focus(); // Foco no maskedtextbox

            }
        }

        private void rdbemail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbemail.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                              
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar

            }
        }

        private void FrmClientes_KeyDown(object sender, KeyEventArgs e)
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
    }

}
