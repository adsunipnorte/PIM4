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
    public partial class FrmCadCondutores : Form
    {
        public FrmCadCondutores()
        {
            InitializeComponent();
        }

        private void btnsaircli_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtnome.Focus();    // Coloca foco no nome caso digite "não" no messagebox
            }

        }
    }
}
