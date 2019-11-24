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
    public partial class FrmPecas : Form
    {
        public FrmPecas()
        {
            InitializeComponent();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "" && msktxtpesquisa.Text=="") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }

            else if (rdbpeca.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando pelo texto contido no textbox
            {
                txtpesquisar.TextName = "";
                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select ID, descricao, estoquemin, estoquemax, quantidade, custo, custoant  from tb_estoque where upper(descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvpecas.DataSource = dt;
                    txtpesquisar.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbestoquemin.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                msktxtpesquisa.Visible = true;
                msktxtpesquisa.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select ID, descricao, estoquemin, estoquemax, quantidade, custo, custoant  from tb_estoque where Estoquemin <=" + msktxtpesquisa.Text + "";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpecas.DataSource = dt;
                msktxtpesquisa.Focus();

            }

            else if (rdbestoquemax.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                msktxtpesquisa.Visible = true;
                msktxtpesquisa.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select ID, descricao, estoquemin, estoquemax, quantidade, custo, custoant  from tb_estoque where Estoquemax >=" + msktxtpesquisa.Text + "";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvpecas.DataSource = dt;
                msktxtpesquisa.Focus();

            }

        }

        private void rdbpeca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpeca.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = false;
                txtpesquisar.Visible = true;
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void rdbestoquemin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbestoquemin.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = true;
                txtpesquisar.Visible = false;
                msktxtpesquisa.Text = ""; // Textbox pesquisar é limpo
                msktxtpesquisa.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void rdbestoquemax_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbestoquemax.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = true;
                txtpesquisar.Visible = false;
                msktxtpesquisa.Text = ""; // Textbox pesquisar é limpo
                msktxtpesquisa.Focus(); // Coloca foco no textbox pesquisar
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
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

        private void FrmPecas_KeyDown(object sender, KeyEventArgs e)
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
        public static void AllowNumber(KeyPressEventArgs e) // Método permite somente digitar número em maskedtextbox
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir
                                  //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..

            //Abaixo só é permito de 0 a 9
            //if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.Handled = true; //Allow only numbers
        }

        private void msktxtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowNumber(e); // Chamando método que permite somente número no maskedtextbox
        }

        private void FrmPecas_Load(object sender, EventArgs e)
        {
            rdbpeca.Checked = false;
            rdbestoquemax.Checked = false;
            rdbestoquemin.Checked = false;
            msktxtpesquisa.Location = new Point(589, 58); // Coloca maskedtextbox na mesma posição do textbox descrição
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadPeca formpeca = new FrmCadPeca();
            formpeca.Show();
        }
    }
}
