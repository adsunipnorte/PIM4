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
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void lblcompl_Click(object sender, EventArgs e)
        {

        }

        private void lblie_Click(object sender, EventArgs e)
        {

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
                txtrazaosocial.Focus(); // Coloca foco na razão social caso digite "não" no messagebox
            }

        }

        private void btnlimparcli_Click(object sender, EventArgs e)
        {
            
          

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
                txtrazaosocial.Focus(); // Coloca foco na razão social caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtrazaosocial.Clear();
            txtfantasia.Clear();
            txtend.Clear();
            txtnumero.Clear();
            txtcompl.Clear();
            txtbairro.Clear();
            txtcep.Clear();
            txtcnpj.Clear();
            txtie.Clear();
            txtim.Clear();
            txtemail.Clear();
            txtsite.Clear();
            txttel.Clear();
            txtcel.Clear();
            rtbobs.Clear();
        }

        private void btncadcli_Click(object sender, EventArgs e)
        {

        }
    }
}
