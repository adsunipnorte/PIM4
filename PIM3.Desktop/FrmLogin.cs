using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            label3.Visible = false;
            checkBox1.Visible = false;
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlogin_Click(object sender, EventArgs e)
        {

            // Melhorar sistema de login, cria classe usuario com atributos          
            string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            //cria a conexão
            SqlConnection com = new SqlConnection(strConxao);

            //cria a instrução de consulta ao banco
            string query = "select login, senha from tb_usuarios where login = '" + txtusuario.TextName + "' and senha = '" + txtsenha.TextName + "'";

            //cria o objeto sqladapter
            SqlDataAdapter comando = new SqlDataAdapter(query, com);

            //instancia o datatable
            DataTable dt = new DataTable();

            //preenche o datatable

            comando.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FrmPrincipal menu = new FrmPrincipal();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login/Senha inválido");

            }


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            // Melhorar sistema de login, cria classe usuario com atributos          
            string strConxao = "Data Source=(local);Initial Catalog=efleet;Integrated Security=True";
            //cria a conexão
            SqlConnection com = new SqlConnection(strConxao);

            //cria a instrução de consulta ao banco
            string query = "select login, senha from tb_usuarios where login = '" + txtusuario.TextName + "' and senha = '" + txtsenha.TextName + "'";

            //cria o objeto sqladapter
            SqlDataAdapter comando = new SqlDataAdapter(query, com);

            //instancia o datatable
            DataTable dt = new DataTable();

            //preenche o datatable

            comando.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FrmPrincipal menu = new FrmPrincipal();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login/Senha inválido");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
