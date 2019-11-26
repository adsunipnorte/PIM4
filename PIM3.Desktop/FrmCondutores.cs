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
    public partial class FrmCondutores : Form
    {
        public FrmCondutores()
        {
            InitializeComponent();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadCondutores cadcondutor = new FrmCadCondutores();
            cadcondutor.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadCondutores altcondutor = new FrmCadCondutores();
            altcondutor.Show();
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCondutores novocondutor = new FrmCadCondutores();
            novocondutor.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCondutores altcondutor = new FrmCadCondutores();
            altcondutor.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCondutores_KeyDown(object sender, KeyEventArgs e)
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
            if (txtpesquisar.TextName == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpesquisar.Focus();

            }


            else if (rdbnome.Checked == true) // Caso radiobutton esteja marcado, faz select pesquisando por texto contido no textbox
            {


                txtpesquisar.Focus();
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select nome, celular, email, cnh from tb_condutores where upper(nome) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcondutores.DataSource = dt;
                txtpesquisar.Focus();

            }

            else if (rdbemail.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {

                txtpesquisar.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select nome, celular, email, cnh from tb_condutores where upper(email) like '%" + txtpesquisar.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcondutores.DataSource = dt;
                txtpesquisar.Focus();
            }
        }

        private void rdbnome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbnome.Checked == true) // Verifica se radiobutton  está marcado, caso esteja coloca o foco no textbox pesquisar
            {

                txtpesquisar.TextName = ""; // Limpa textbox
                txtpesquisar.Focus(); // Foco no textbox

            }
        }

        private void rdbemail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbemail.Checked == true) // Verifica se radiobutton está marcado, caso esteja coloca o foco no textbox pesquisar
            {

                txtpesquisar.TextName = ""; // Limpa textbox
                txtpesquisar.Focus(); // Foco no textbox

            }
        }
    }
}
