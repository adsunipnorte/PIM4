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
using DLLComando;


namespace PIM3.Desktop
{
    public partial class FrmCentroCusto : Form
    {
        public FrmCentroCusto()
        {
            InitializeComponent();
        }


        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto cadCentroCusto = new FrmCadCentroCusto();
            cadCentroCusto.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto altcentrocusto = new FrmCadCentroCusto();
            altcentrocusto.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto novocentrocusto = new FrmCadCentroCusto();
            novocentrocusto.Show();
        }

        private void btncalt_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto altcentrocusto = new FrmCadCentroCusto();
            altcentrocusto.Show();
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
                string Query = "select tb_centrocustos.id, tb_centrocustos.descricao as DESCRICAO, tb_situacao.descricao as SITUACAO from tb_centrocustos inner join tb_situacao on tb_situacao.id=tb_centrocustos.situacao where tb_centrocustos.id =" + Convert.ToString(msktxtpesquisa.Text);
                SqlConnection con = new SqlConnection(strConxao);

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvcentrocusto.DataSource = dt;
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
                string Query = "select tb_centrocustos.id, tb_centrocustos.descricao as DESCRICAO, tb_situacao.descricao as SITUACAO from tb_centrocustos inner join tb_situacao on tb_situacao.id=tb_centrocustos.situacao where upper(tb_centrocustos.descricao) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strCnxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, strCnxao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcentrocusto.DataSource = dt;
                txtpesquisar.Focus();

            }

        }


        private void rdbid_CheckedChanged(object sender, EventArgs e) // Método verifica se check de radiobutton ID é alterado
        {
            
            if (rdbid.Checked == true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
            {
                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                txtpesquisar.Visible = false; // textbox pesquisar fica invisível
                msktxtpesquisa.Clear(); // Limpa maskedtextbox
                msktxtpesquisa.Focus(); // Foco no maskedtextbox
                
            }
            
        }

        private void rdbdescricao_CheckedChanged(object sender, EventArgs e) // Método verifica se check de radiobutton descrição é alterado
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

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e) // Método KeyPress do Maskedtextbox
        {
            AllowNumber(e); // Chamando método que permite somente número no maskedtextbox
        }

        private void FrmCentroCusto_Load(object sender, EventArgs e)
        {
            rdbid.Checked = false;
            rdbdescricao.Checked = false;
            msktxtpesquisa.Location = new Point(514, 59); // Coloca maskedtextbox na mesma posição do textbox descrição
        }

        private void FrmCentroCusto_KeyDown(object sender, KeyEventArgs e)
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


        private void consultar() // Metodo para teste
        {
            string sql = "select id, descricao, situacao from tb_centrocustos where upper(Descricao) like '%" + txtpesquisar.TextName.ToUpper() + "%'";
            SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            da.Dispose();

            dgvcentrocusto.DataSource = dt;
        }

        public void validacheckbox() // Método para testar se textbox e maskedtextbox estão preenchidos
        {
            if (txtpesquisar.TextName == "" && msktxtpesquisa.Text == "") // Verifica se o textbox ou maskedtextbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }
        }
    }
}


