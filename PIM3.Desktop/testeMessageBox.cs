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
        public testeMessageBox(String _message)
        {
            InitializeComponent();
            lblregistroinserido.Text = _message;
        }

        public testeMessageBox(testeMessageBox msg)
        {
        }

        public testeMessageBox()
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

         

            if (MessageBox.Show("Dssfdsfasdfsd", "fdfsfd", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            {
                
            }
        }

        private void testeMessageBox_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this); // Faz com que form apareça suavemente
        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            atrasoIcone.Start();
            icone.Enabled = true;

        }

        private void atrasoIcone_Tick(object sender, EventArgs e)
        {
            icone.Enabled = false;
            atrasoIcone.Stop();
            btnsucesso.Visible = true;
        }

        private void btnsucesso_Click(object sender, EventArgs e)
        {
            btnsucesso.Enabled = false;
            this.Close();
        }

        public static  void mostraMensagem(String message)
        {
            testeMessageBox msg = new PIM3.Desktop.testeMessageBox(message);
            msg.ShowDialog();
        }
    }
}
