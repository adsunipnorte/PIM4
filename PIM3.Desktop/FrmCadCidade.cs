using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM3.Desktop
{
    public partial class FrmCadCidade : Form
    {
        public FrmCadCidade()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {
                this.Close();
            }
            else
            {
                txtnomecid.Focus(); // Coloca foco no nome da cidade caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtnomecid.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtcodcidade.Clear();
            txtnomecid.Clear();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcodcidade.Focus();
            }

            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_cidades(codcidade, nome)VALUES('" + txtcodcidade.Text + "'," + "'" + txtnomecid.Text + "'" + ")"; // Variável que recebe comando SQL
                con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
            }
        }

        private void btngravar_TabIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }
    }
}
