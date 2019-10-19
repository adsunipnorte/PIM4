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

        private void addFromDb(Bunifu.Framework.UI.BunifuDropdown cmbpesqcentrocusto)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tb_centrocustos", con);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmbpesqcentrocusto.AddItem(read.GetString(0));
            }
            con.Close();
        }

        private void FrmCentroCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) // Verifica se a tecla ESC foi pressionada
            {
                if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo, // Caso escolha "sim" é fechada janela
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    this.Close();
                }
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtpesquisar.TextName == "" && msktxtpesquisa.Text=="") // Verifica se o textbox ou maskedtextbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }

            else if (rdbid.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no maskedtextbox
            {


                msktxtpesquisa.Visible = true; // maskedtextbox fica visivel
                msktxtpesquisa.Focus(); // Foco é colocado em maskedtextbox



                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select id, descricao, situacao from tb_centrocustos where id =" + Convert.ToString(msktxtpesquisa.Text);
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcentrocusto.DataSource = dt;
                msktxtpesquisa.Focus();
                
            }

            else if (rdbdescricao.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {
                txtpesquisar.TextName = ""; // textbox recebe vazio
                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select id, descricao, situacao from tb_centrocustos where Descricao like \'%" + txtpesquisar.TextName + "%\'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcentrocusto.DataSource = dt;
                txtpesquisar.Focus();
            }


        }

              
        private void rdbid_CheckedChanged(object sender, EventArgs e) // Método verifica se check de radiobutton ID é alterado
        {
            if (rdbid.Checked==true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no maskedtextbox pesquisar
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

        

        private void txtpesquisar_Load(object sender, EventArgs e)
        {

        }
    }
}


