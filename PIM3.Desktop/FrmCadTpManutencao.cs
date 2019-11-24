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
    public partial class FrmCadTpManutencao : Form
    {
        public FrmCadTpManutencao()
        {
            InitializeComponent();
        }

        private void FrmTpManutencao_Load(object sender, EventArgs e)
        {

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
                txtdescricao.Focus(); // Coloca o foco na descriçã caso digite "não" no messagebox
            }
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

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdescricao.Text))
            {
                MessageBox.Show("Campo descrição não está preenchido.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            {
                ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                string var = "INSERT INTO tb_tipomanutencao(descricao)VALUES('" + txtdescricao.Text.ToUpper() + "'" + ")"; // Variável que recebe comando SQL

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
    }
}
