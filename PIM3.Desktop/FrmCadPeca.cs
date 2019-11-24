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
    public partial class FrmCadPeca : Form
    {
        public FrmCadPeca()
        {
            InitializeComponent();
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
                txtdescricao.Focus();
            }
        }

        private void FrmCadPeca_KeyDown(object sender, KeyEventArgs e)
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
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }


            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_estoque(descricao, estoquemin, estoquemax, quantidade, custo)VALUES('" + txtdescricao.Text.ToUpper() + "'," + txtestoquemin.Text + "," + txtestoquemax.Text + "," + txtquantidade.Text + "," + txtcusto.Text + ")"; // Variável que recebe comando SQL
                con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
                txtdescricao.Clear();

               


            }
        }
    }
}
