using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PIM3.Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
            
        {
                
                

            if (txtusuario.Text=="sa" && txtsenha.Text=="sa")
            {
               FrmLogin login = new FrmLogin();
                FrmPrincipal principal = new FrmPrincipal();

                login.Close();
                principal.Show();
               
                

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusuario.Focus();
            }
        }
    }
}
