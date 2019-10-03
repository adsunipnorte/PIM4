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
    }
}
