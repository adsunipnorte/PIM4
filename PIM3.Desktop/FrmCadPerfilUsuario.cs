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
    public partial class FrmCadPerfilUsuario : Form
    {
        public FrmCadPerfilUsuario()
        {
            InitializeComponent();
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
                txtdescricao.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
            }
        }

        private void chkfiltro_CheckedChanged(object sender, EventArgs e)
        {
           /* if (chkfiltro.Checked == true)
            {
                btncad.Visible = false;  Aciona checkbox e esconde botão
            }
            else
            {
                btncad.Show();
            } */
        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadPerfilUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
