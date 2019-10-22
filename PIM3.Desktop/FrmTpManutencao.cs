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
    public partial class FrmTpManutencao : Form
    {
        public FrmTpManutencao()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpManutencao novotpmanutencao = new FrmCadTpManutencao();
            novotpmanutencao.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpManutencao altmanutencao = new FrmCadTpManutencao();
            altmanutencao.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
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
            FrmCadTpManutencao alttpmanutencao = new FrmCadTpManutencao();
            alttpmanutencao.Show();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadTpManutencao novotpmanutencao = new FrmCadTpManutencao();
            novotpmanutencao.Show();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "" && msktxtpesquisa.Text == "") // Verifica se o textbox ou maskedtextbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }


            else if (rdbid.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no maskedtextbox
            {


                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                msktxtpesquisa.Focus(); // Foco é colocado em maskedtextbox

                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select id, descricao from tb_tipomanutencao where id =" + Convert.ToString(msktxtpesquisa.Text);
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvtpmanutencao.DataSource = dt;
                    msktxtpesquisa.Focus();
                }
                catch (Exception erro)
                {
                    string mensagem = erro.Message;
                    mensagem += "Não foi possivel conectar ao banco de dados.";

                }

            }

            else if (rdbdescricao.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strCnxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select id, descricao from tb_tipomanutencao where upper(descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvtpmanutencao.DataSource = dt;
                txtpesquisar.Focus();

            }
        }

        private void rdbid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbid.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                txtpesquisar.Visible = false; // textbox pesquisar fica invisível
                msktxtpesquisa.Clear(); // Limpa maskedtextbox
                msktxtpesquisa.Focus(); // Foco no maskedtextbox

            }
        }

        private void rdbdescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdescricao.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = false; // Maskedtextbox fica invisível
                txtpesquisar.Visible = true; // Textbox pesquisar fica visível
                txtpesquisar.TextName = ""; // Textbox pesquisar é limpo
                txtpesquisar.Focus(); // Coloca foco no textbox pesquisar
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

        private void FrmTpManutencao_Load(object sender, EventArgs e)
        {
            msktxtpesquisa.Location = new Point(500, 67); // Coloca maskedtextbox na mesma posição do textbox descrição
        }

        private void FrmTpManutencao_KeyDown(object sender, KeyEventArgs e)
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
                    msktxtpesquisa.Focus();
                }
            }
        }
    }
}
