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
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection
                ("server=localhost;port=3306;user id=root; database=efleet; password=");
                objcon.Open();
                MessageBox.Show("Conectado");
                objcon.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Nao Conectado");
            }
        }

       

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            alert.Show("Registro inserido com sucesso.", alert.AlertType.success);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            alert.Show("Registro inserido com sucesso.", alert.AlertType.error);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            alert.Show("Registro inserido com sucesso.", alert.AlertType.info);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            alert.Show("Registro inserido com sucesso.", alert.AlertType.warnig);
        }

        private void Teste_Load(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRelusuarios ftm = new FrmRelusuarios();
            ftm.Show();
        }
    }
}
