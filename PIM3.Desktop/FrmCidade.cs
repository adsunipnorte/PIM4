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
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadCidade cadcidade = new FrmCadCidade();
            cadcidade.Show();
        }

        private void btncalt_Click(object sender, EventArgs e)
        {
            FrmCadCidade altcidade = new FrmCadCidade();
            altcidade.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCidade novacidade = new FrmCadCidade();
            novacidade.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCidade altcidade = new FrmCadCidade();
            altcidade.Show();
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

        private void FrmCidade_KeyDown(object sender, KeyEventArgs e)
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
                    txtestado.Focus();
                    
                }
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            if (txtestado.TextName == "") // Verifica se o textbox está em branco
            {
                MessageBox.Show("Digite um termo para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtestado.Focus();
                
            }


            else if (rdbcidade.Checked == true) // Caso radiobutton esteja marcado, faz select pesquisando por texto contido no textbox
            {

                
                txtestado.Focus();
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select codcidade, nome, estado from tb_cidades INNER join tb_estados on tb_estados.id= tb_cidades.idestados where upper(nome) like '%" + txtestado.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcidade.DataSource = dt;
                txtestado.Focus();

            }

            else if (rdbestado.Checked == true) // Caso radiobutton esteja marcado, faz pesquisa pela descrição contida no textbox
            {
                
                txtestado.Focus(); // Foco é colocado em textbox
                string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
                string Query = "select codcidade, nome, Estado  from tb_cidades left join tb_estados on tb_estados.id= tb_cidades.idestados where upper(estado) like '%" + txtestado.TextName + "%'";
                SqlConnection con = new SqlConnection(strConxao);
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcidade.DataSource = dt;
                txtestado.Focus();
            }
        }

        private void rdbcidade_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbcidade.Checked == true) // Verifica se radiobutton  está marcado, caso esteja coloca o foco no textbox pesquisar
            {
                
                txtestado.TextName=""; // Limpa textbox
                txtestado.Focus(); // Foco no textbox
                
            }
        }

        private void rdbestado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbestado.Checked == true) // Verifica se radiobutton está marcado, caso esteja coloca o foco no textbox pesquisar
            {

                txtestado.TextName = ""; // Limpa textbox
                txtestado.Focus(); // Foco no textbox

            }
        }
    }
}
