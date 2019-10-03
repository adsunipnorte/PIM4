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
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
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

        private void chkfitro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfitro.Checked == true)
            {
                cmbfiltro.Show();
            }
            else
            {
                cmbfiltro.Visible = false;
            }
        }
    }
}
