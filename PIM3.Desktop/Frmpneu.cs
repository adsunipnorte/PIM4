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
    public partial class Frmpneu : Form
    {
        public Frmpneu()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }

            else if (rdbperfil.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando pelo texto contido no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_pneus.Id, tb_pneus.Perfil, tb_pneus.DataCompra, tb_pneus.Valor, tb_veiculos.Modelo as veiculo, tb_pneus.PlacaVeiculo, tb_pneus.Km from tb_pneus inner join tb_veiculos on tb_veiculos.Id=tb_pneus.IdVeiculo where upper(tb_pneus.perfil) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvpneus.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }



            else if (rdbveiculo.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_pneus.Id, tb_pneus.Perfil, tb_pneus.DataCompra, tb_pneus.Valor, tb_veiculos.Modelo as veiculo, tb_pneus.PlacaVeiculo, tb_pneus.Km from tb_pneus inner join tb_veiculos on tb_veiculos.Id=tb_pneus.IdVeiculo where upper(tb_veiculos.modelo) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpneus.DataSource = dt;
                txtpesquisar.Focus();

            }

            else if (rdbplaca.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_pneus.Id, tb_pneus.Perfil, tb_pneus.DataCompra, tb_pneus.Valor, tb_veiculos.Modelo as veiculo, tb_pneus.PlacaVeiculo, tb_pneus.Km from tb_pneus inner join tb_veiculos on tb_veiculos.Id=tb_pneus.IdVeiculo where upper(tb_veiculos.placa) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpneus.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void rdbperfil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbperfil.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void rdbveiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbveiculo.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtpesquisar.Focus();
            }
        }

        private void Frmpneu_KeyDown(object sender, KeyEventArgs e)
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
            FrmCadPneu formpneu = new FrmCadPneu();
            formpneu.Show();
        }
    }
}
