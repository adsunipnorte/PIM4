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
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void chkfiltro_CheckedChanged(object sender, EventArgs e)
        {
            if(chkfiltro.Checked==true) //verifica se checkbox está selecionado, caso sim mostra combobox filtro
            {
                cmbfiltro.Show();
            }
            else
            {
                cmbfiltro.Visible = false; // caso não esteja selecionado, marca false no combobox
            }
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
    }
}
