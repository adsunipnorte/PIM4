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
    public partial class FrmVeiculo : Form
    {
        public FrmVeiculo()
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
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo altveiculo = new FrmCadVeiculo();
            altveiculo.Show();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadVeiculo cadveiculo = new FrmCadVeiculo();
            cadveiculo.Show();
        }
    }
}
