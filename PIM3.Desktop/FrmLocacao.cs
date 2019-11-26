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
    public partial class FrmLocacao : Form
    {
        public FrmLocacao()
        {
            InitializeComponent();
        }

        
        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadLocacao novalocacao = new FrmCadLocacao();
            novalocacao.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadLocacao altlocacao = new FrmCadLocacao();
            altlocacao.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLocacao novalocacao = new FrmCadLocacao();
            novalocacao.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLocacao altlocacao = new FrmCadLocacao();
            altlocacao.Show();
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

        private void FrmLocacao_KeyDown(object sender, KeyEventArgs e)
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


            else if (rdbveiculo.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no maskedtextbox
            {

                
                txtpesquisar.Focus(); // Foco é colocado em maskedtextbox

                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_locacoes.id as ID, tb_veiculos.modelo as Veiculo, tb_veiculos.placa as Placa, tb_locacoes.valordiaria as Diaria  from tb_locacoes inner join tb_veiculos on tb_veiculos.id=tb_locacoes.idveiculo where upper(tb_veiculos.modelo) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvlocacao.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbplaca.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_locacoes.id as ID, tb_veiculos.modelo as Veiculo, tb_veiculos.placa as Placa, tb_locacoes.valordiaria as Diaria  from tb_locacoes inner join tb_veiculos on tb_veiculos.id=tb_locacoes.idveiculo where upper(tb_veiculos.placa) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvlocacao.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void rdbveiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbveiculo.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {
                
                txtpesquisar.TextName=""; // Limpa maskedtextbox
                txtpesquisar.Focus(); // Foco no maskedtextbox

            }
        }

        private void rdbplaca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbplaca.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar

            }
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
