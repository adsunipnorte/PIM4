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
    public partial class FrmVeiculo : Form
    {
        public FrmVeiculo()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo altveiculo = new FrmCadVeiculo();
            altveiculo.Show();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo cadveiculo = new FrmCadVeiculo();
            cadveiculo.Show();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }

            else if (rdbplaca.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando pelo texto contido no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_veiculos.Placa as placa, tb_montadoras.Descricao AS montadora,  tb_veiculos.Modelo AS modelo,  tb_tipoveiculo.Descricao AS tipoveiculo from tb_veiculos LEFT join tb_montadoras on tb_montadoras.id=tb_veiculos.idmontadoras LEFT JOIN tb_tipoveiculo ON tb_tipoveiculo.Id=tb_veiculos.IdTipoVeiculo where upper(tb_veiculos.placa) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvveiculo.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            

            else if (rdbmodelo.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_veiculos.Placa as placa, tb_montadoras.Descricao AS montadora,  tb_veiculos.Modelo AS modelo,  tb_tipoveiculo.Descricao AS tipoveiculo from tb_veiculos LEFT join tb_montadoras on tb_montadoras.id=tb_veiculos.idmontadoras LEFT JOIN tb_tipoveiculo ON tb_tipoveiculo.Id=tb_veiculos.IdTipoVeiculo where upper(tb_veiculos.modelo) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvveiculo.DataSource = dt;
                txtpesquisar.Focus();

            }

            else if (rdbmontadora.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_veiculos.Placa as placa, tb_montadoras.Descricao AS montadora,  tb_veiculos.Modelo AS modelo,  tb_tipoveiculo.Descricao AS tipoveiculo from tb_veiculos LEFT join tb_montadoras on tb_montadoras.id=tb_veiculos.idmontadoras LEFT JOIN tb_tipoveiculo ON tb_tipoveiculo.Id=tb_veiculos.IdTipoVeiculo where upper(tb_montadoras.descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvveiculo.DataSource = dt;
                txtpesquisar.Focus();

            }

            else if (rdbtpveiculo.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select tb_veiculos.Placa as placa, tb_montadoras.Descricao AS montadora,  tb_veiculos.Modelo AS modelo,  tb_tipoveiculo.Descricao AS tipoveiculo from tb_veiculos LEFT join tb_montadoras on tb_montadoras.id=tb_veiculos.idmontadoras LEFT JOIN tb_tipoveiculo ON tb_tipoveiculo.Id=tb_veiculos.IdTipoVeiculo where upper(tb_tipoveiculo.descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvveiculo.DataSource = dt;
                txtpesquisar.Focus();

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

        
        private void rdbmodelo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmodelo.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void rdbmontadora_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbmontadora.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void rdbtpveiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtpveiculo.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }
    }
}
