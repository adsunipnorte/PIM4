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
    public partial class FrmTpCliente : Form
    {
        public FrmTpCliente()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpCliente novotpcliente = new FrmCadTpCliente();
            novotpcliente.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadTpCliente alttpcliente = new FrmCadTpCliente();
            alttpcliente.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCadTpCliente novotpcliente = new FrmCadTpCliente();
            novotpcliente.Show();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            FrmCadTpCliente alttpcliente = new FrmCadTpCliente();
            alttpcliente.Show();
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
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
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