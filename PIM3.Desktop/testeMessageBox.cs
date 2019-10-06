using Bunifu.Framework.UI;
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
    public partial class testeMessageBox : Form
    {
        public testeMessageBox()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuFlatButton1 = (BunifuFlatButton)sender;

         

            if (MessageBox.Show("Dssfdsfasdfsd", "fdfsfd", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            {
                bunifuFlatButton1.Enabled = false;
                this.Close();
            }
        }
    }
}
