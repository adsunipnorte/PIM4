﻿using System;
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
    public partial class FrmCentroCusto : Form
    {
        public FrmCentroCusto()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto cadCentroCusto = new FrmCadCentroCusto();
            cadCentroCusto.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        
        private void cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto altcentrocusto= new FrmCadCentroCusto();
            altcentrocusto.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto novocentrocusto = new FrmCadCentroCusto();
            novocentrocusto.Show();
        }

        private void btncalt_Click(object sender, EventArgs e)
        {
            FrmCadCentroCusto altcentrocusto = new FrmCadCentroCusto();
            altcentrocusto.Show();
        }

        private void chkpesquisar_OnChange(object sender, EventArgs e)
        {
            if (chkpesquisar.Checked == true)
            {
                cmbpesqcentrocusto.Visible = true;
            }

            else
            {
                cmbpesqcentrocusto.Visible = false;
            }
        }

        
    }
}
