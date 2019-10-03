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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void motoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiro consultacontasapagar = new FrmFinanceiro();
            consultacontasapagar.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes cliente = new FrmClientes();
            cliente.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void condutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCondutores consultacondutor = new FrmCondutores();
            consultacondutor.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado estado = new FrmEstado();
            estado.Show();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void seguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeguro seguro = new FrmSeguro();
            seguro.Show();
        }

        private void tipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contatoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentroCusto centroCusto = new FrmCentroCusto();
            centroCusto.Show();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanoContas planocontas = new FrmPlanoContas();
            planocontas.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmClientes consultacliente = new FrmClientes();
            consultacliente.Show();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente cadcliente = new FrmCadCliente(); // Chama formulário cadastro de clientes
            cadcliente.Show();
        }

        private void tipoClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadTpCliente tpCliente = new FrmCadTpCliente();
            tpCliente.Show();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadContatoCliente contatoCliente = new FrmCadContatoCliente();
            contatoCliente.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmClientes Cliente = new FrmClientes();
            Cliente.Show();
        }

        private void novoCondutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCondutores condutores = new FrmCadCondutores();
            condutores.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade cidade = new FrmCidade();
            cidade.Show();
        }

        private void condutoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCondutores consultacondutor = new FrmCondutores();
            consultacondutor.Show();
        }

        private void fonecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes consultacliente = new FrmClientes();
            consultacliente.Show();
        }

        private void novoFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCliente novofornecedor = new FrmCadCliente();
            novofornecedor.Show();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadUsuario novousuario = new FrmCadUsuario();
            novousuario.Show();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidade consultacidade = new FrmCidade();
            consultacidade.Show();
        }

        private void novaCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCidade novacidade = new FrmCadCidade();
            novacidade.Show();
        }

        private void tipoClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmTpCliente tpcliente = new FrmTpCliente();
            tpcliente.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes consultacliente = new FrmClientes();
            consultacliente.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFinanceiro consultacontaareceber = new FrmFinanceiro();
            consultacontaareceber.Show();
        }

        private void contatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmContatoCliente consultacontatocliente = new FrmContatoCliente();
            consultacontatocliente.Show();
        }

        private void btnfinanceiro_Click(object sender, EventArgs e)
        {
            FrmFinanceiro contasapagar = new FrmFinanceiro();
            contasapagar.Show();
        }

        private void novaLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocacao locacao = new FrmLocacao();
            locacao.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLocacao consultalocacao = new FrmLocacao();
            consultalocacao.Show();
        }
    }
}
