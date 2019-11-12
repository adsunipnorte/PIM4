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
    public partial class FrmRelusuarios : Form
    {
        public FrmRelusuarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'efleetDataSet.tb_usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuariosTableAdapter.Fill(this.efleetDataSet.tb_usuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
