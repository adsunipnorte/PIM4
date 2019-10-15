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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtdescricao.Clear();
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
            if (string.IsNullOrEmpty(txtdescricao.Text)){
                MessageBox.Show("Campo descrição não está preenchido.", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
