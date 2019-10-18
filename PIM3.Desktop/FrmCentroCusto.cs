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


        private void cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (txtpesquisar.TextName == "") // Verifica se o textbox estão em branco
            {
                MessageBox.Show("Digite um termo para pesquisa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();
            }

            else if (rdbid.Checked == true) // Caso radiobutton ID esteja marcado, faz select pesquisando por número contido no textbox
            {

                txtpesquisar.Focus();
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select id, descricao, situacao from tb_centrocustos where id =" + Convert.ToString(txtpesquisar.TextName);
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcentrocusto.DataSource = dt;
                txtpesquisar.Focus();
            }

            else if (rdbdescricao.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {
                txtpesquisar.Focus();
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

              
        private void rdbid_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbid.Checked==true) // Verifica se radiobutton ID está marcado, caso esteja coloca o foco no textbox pesquisar
            {
                txtpesquisar.Focus();
            }
        }

        private void rdbdescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdescricao.Checked == true) // Verifica se radiobutton descrição está marcado, sendo verdadeiro coloca o foco no textbox pesquisar
            {
                txtpesquisar.Focus();
            }
        }
    }
}


