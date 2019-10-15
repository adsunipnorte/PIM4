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
    public partial class FrmCadSeguro : Form
    {
        public FrmCadSeguro()
        {
            InitializeComponent();
        }

        private void btnsaircli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

            else
            {
                txtseguro.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtseguro.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtseguro.Clear();
            txtobs.Clear();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtseguro.Text))
            {
                MessageBox.Show("Campo descrição não preenchido", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtseguro.Focus();
            }

            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_seguros(descricao, observacao)VALUES('" + txtseguro.Text + "'," + "'" + txtobs.Text + "'" + ")"; // Variável que recebe comando SQL
                con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro
                txtid.Clear();
                txtseguro.Clear();
                txtobs.Clear();
                txtseguro.Focus();
            }
            

        }
    }
}
