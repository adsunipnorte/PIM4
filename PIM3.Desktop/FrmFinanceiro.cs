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
    public partial class FrmFinanceiro : Form
    {
        public FrmFinanceiro()
        {
            InitializeComponent();
        }

        
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro novofinanceiro = new FrmCadFinanceiro();
            novofinanceiro.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro altfinanceiro = new FrmCadFinanceiro();
            altfinanceiro.Show();
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

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro altfinanceiro = new FrmCadFinanceiro();
            altfinanceiro.Show();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro novofinaceiro = new FrmCadFinanceiro();
            novofinaceiro.Show();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "" && msktxtpesquisa.Text == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();

            }


            else if (rdbcliente.Checked == true) // Caso radiobutton esteja marcado, faz select pesquisando por texto contido no textbox
            {

                
                txtpesquisar.Focus();
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_financeiro.id as ID, tb_clientes.fantasia as Cliente, tb_financeiro.descricao as Descricao, tb_financeiro.valororig as Valor, tb_financeiro.vencimento as Vencimento from tb_financeiro left join tb_clientes on tb_clientes.id=tb_financeiro.idclientes where upper(tb_clientes.fantasia) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvfinanceiro.DataSource = dt;
                txtpesquisar.Focus();

            }

            else if (rdbvencimento.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                DateTime venc = DateTime.Parse(msktxtpesquisa.Text);
                //msktxtpesquisa.Text = venc.ToString("yyyy/mm/dd");
                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                msktxtpesquisa.Focus(); // Foco é colocado em maskedtextbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_financeiro.id as ID, tb_clientes.fantasia as Cliente, tb_financeiro.descricao as Descricao, tb_financeiro.valororig as Valor, tb_financeiro.vencimento as Vencimento from tb_financeiro left join tb_clientes on tb_clientes.id=tb_financeiro.idclientes where tb_financeiro.vencimento =" + (venc) + "";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvfinanceiro.DataSource = dt;
                txtpesquisar.Focus();
            }
        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {
            msktxtpesquisa.Location = new Point(494, 49); // Coloca maskedtextbox na mesma posição do textbox descrição
        }

        private void rdbcliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbcliente.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = false; // Maskedtextbox fica invisível
                txtpesquisar.Visible = true; // Textbox pesquisar fica visível
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar

            }
        }

        private void rdbvencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbvencimento.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                txtpesquisar.Visible = false; // textbox pesquisar fica invisível
                msktxtpesquisa.Clear(); // Limpa maskedtextbox
                msktxtpesquisa.Focus(); // Foco no maskedtextbox

            }
        }
    }
}
