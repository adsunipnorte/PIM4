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
    public partial class FrmCadPlanoContas : Form
    {
        public FrmCadPlanoContas()
        {
            InitializeComponent();
        }

        private void FrmPlanoContas_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {

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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdescricao.Clear();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }

        }
    }
}
