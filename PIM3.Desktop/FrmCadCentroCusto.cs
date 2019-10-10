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
    public partial class FrmCadCentroCusto : Form
    {
        public FrmCadCentroCusto()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void FrmCadCentroCusto_Load(object sender, EventArgs e)
        {

        }

        private void chksituacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnerro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnsucesso_Click(object sender, EventArgs e)
        {
            string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            string Query = "INSERT INTO tb_centrocustos(descricao)VALUES('" + txtdescricao.Text + "'" + ")";
            SqlConnection con = new SqlConnection(strConxao);
            SqlCommand sqlCommand = new SqlCommand(Query, con);

            con.Open();

            sqlCommand.ExecuteNonQuery();

            con.Close();

            
            //lblcodcategoria.Text = "Registro Inserido Com Sucesso";
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtid.Clear();
            txtdescricao.Clear();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            string Query = "Select * from tb_centrocustos";
            SqlConnection con = new SqlConnection(strConxao);
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvteste.DataSource = dt;
        }
    }
}
