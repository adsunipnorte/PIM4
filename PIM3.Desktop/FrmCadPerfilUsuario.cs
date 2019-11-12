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
    public partial class FrmCadPerfilUsuario : Form
    {
        public FrmCadPerfilUsuario()
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
                txtdescricao.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
            }
        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadPerfilUsuario_Load(object sender, EventArgs e)
        {

        }

        private void FrmCadPerfilUsuario_KeyDown(object sender, KeyEventArgs e)
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
                    txtdescricao.Focus();
                }
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdescricao.Text))
            {
                MessageBox.Show("É necessario preencher o campo DESCRICAO.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }

            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_perfilusuarios(descricao)VALUES('" + txtdescricao.Text + "'" + ")"; // Variável que recebe comando SQL

                try
                {
                    con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
                    MessageBox.Show("Registro inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdescricao.Clear();
                    txtdescricao.Focus();
                }
                catch (Exception ex)
                {
                    string erro = ex.Message;
                    erro += "Não foi possivel concluir a operacao";
                }
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdescricao.Clear();
            txtdescricao.Focus();
        }

        private void btnsair_Click_1(object sender, EventArgs e)
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
    }
}
