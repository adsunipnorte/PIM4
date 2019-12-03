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

namespace PIM3.Desktop
{
    public partial class FrmCadFinanceiro : Form
    {
        public FrmCadFinanceiro()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtvalororiginal.Focus(); // Coloca o foco na descriçã digite "não" no messagebox
            }
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtvalororiginal.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        
        //----------------------------------------------------------------------------------------------------
        public void cliente()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_clientes.id as varchar)   +  ' - ' +  tb_clientes.fantasia as CLIENTE from tb_clientes order by tb_clientes.fantasia";

            try
            {
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(con))
                {
                    //Cria um dataadapter para receber o select do banco de dados
                    using (SqlDataAdapter da = new SqlDataAdapter(QuerySQL, conexao))
                    {
                        //cria um datatable
                        DataTable dt = new DataTable();
                        //Faz um fill dos dados do DataAdapter para o DataTable
                        da.Fill(dt);
                        //Fonte de dados do Combobox recebe o datatable
                        this.cmbcliente.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbcliente.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbcliente.ValueMember = "CLIENTE";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        //----------------------------------------------------------------------------------------------------
        public void planocontas()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_planocontas.id as varchar)   +  ' - ' +  tb_planocontas.descricao as PLANOCONTA from tb_planocontas order by tb_planocontas.descricao";

            try
            {
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(con))
                {
                    //Cria um dataadapter para receber o select do banco de dados
                    using (SqlDataAdapter da = new SqlDataAdapter(QuerySQL, conexao))
                    {
                        //cria um datatable
                        DataTable dt = new DataTable();
                        //Faz um fill dos dados do DataAdapter para o DataTable
                        da.Fill(dt);
                        //Fonte de dados do Combobox recebe o datatable
                        this.cmbplanoconta.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbplanoconta.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbplanoconta.ValueMember = "PLANOCONTA";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        //----------------------------------------------------------------------------------------------------
        public void centrocusto()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_centrocustos.id as varchar)   +  ' - ' +  tb_centrocustos.descricao as CENTROCUSTO from tb_centrocustos order by tb_centrocustos.descricao";

            try
            {
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(con))
                {
                    //Cria um dataadapter para receber o select do banco de dados
                    using (SqlDataAdapter da = new SqlDataAdapter(QuerySQL, conexao))
                    {
                        //cria um datatable
                        DataTable dt = new DataTable();
                        //Faz um fill dos dados do DataAdapter para o DataTable
                        da.Fill(dt);
                        //Fonte de dados do Combobox recebe o datatable
                        this.cmbcentrocusto.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbcentrocusto.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbcentrocusto.ValueMember = "CENTROCUSTO";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

               
        

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            cmbcliente.SelectedValue = "";
            cmbcentrocusto.SelectedValue = "";
            cmbplanoconta.SelectedValue = "";
            txtdesconto.Clear();
            txtvalororiginal.Clear();
            txtjuros.Clear();
            txtvalororiginal.Clear();
            txtvalorpago.Clear();
            txtvalororiginal.Focus();
        }

        private void cmbcliente_Click_1(object sender, EventArgs e)
        {
            cliente();
        }

        private void cmbplanoconta_Click(object sender, EventArgs e)
        {
            planocontas();
        }

        private void cmbcentrocusto_Click_1(object sender, EventArgs e)
        {
            centrocusto();
        }

        private void btngravar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtvalororiginal.Text) || string.IsNullOrEmpty(txtdescricao.Text))

            {
                MessageBox.Show("É necessario preencher a DESCRICAO, VALOR ORIGINAL, VENCIMENTO.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbcliente.Focus();
            }


            else if (this.Controls.OfType<ComboBox>().Any(c => string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("É necessario selecionar CLIENTE, PLANO DE CONTAS, CENTRO DE CUSTO.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbcliente.Focus();
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string cliente = cmbcliente.Text;
                    string planocontas = cmbplanoconta.Text; // Variavel combo utilizada para pegar string
                    string centrocusto = cmbcentrocusto.Text;
                    if (string.IsNullOrWhiteSpace(txtdesconto.Text) || string.IsNullOrWhiteSpace(txtjuros.Text) || string.IsNullOrWhiteSpace(txtvalorpago.Text))
                    {
                        txtdesconto.Text = "0";
                        txtjuros.Text = "0";
                        txtvalorpago.Text = "0";

                    }
                    else
                    {
                        txtdesconto.Text = txtdesconto.Text;
                        txtjuros.Text = txtjuros.Text;
                        txtvalorpago.Text = txtvalorpago.Text;

                    }



                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_financeiro (descricao, valororig, vencimento," +
                            "desconto, juros, valorpago, idclientes, idcentrocusto, idplanocontas) " +
                            "VALUES (@descricao, @valororig, @vencimento, @desconto, @juros, @valorpago, @idclientes, @idcentrocusto, @idplanocontas)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@descricao", txtdescricao.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@valororig", txtvalororiginal.Text);
                            cmd.Parameters.Add("@vencimento", this.dtpvencimento.Value.ToShortDateString());
                            cmd.Parameters.Add("@desconto", txtdesconto.Text);
                            cmd.Parameters.Add("@juros", txtjuros.Text); //
                            cmd.Parameters.AddWithValue("@valorpago", txtvalorpago.Text);
                            cmd.Parameters.Add("@idclientes", cliente.Substring(0, 2)); //
                            cmd.Parameters.Add("@idcentrocusto", centrocusto.Substring(0, 2)); //
                            cmd.Parameters.Add("@idplanocontas", planocontas.Substring(0, 2)); //


                            //cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                                cmbcliente.SelectedValue = "";
                                cmbcentrocusto.SelectedValue = "";
                                cmbplanoconta.SelectedValue = "";
                                txtdesconto.Clear();
                                txtvalororiginal.Clear();
                                txtjuros.Clear();
                                txtvalororiginal.Clear();
                                txtvalorpago.Clear();
                                txtvalororiginal.Focus();

                            }
                            else
                            {
                                MessageBox.Show("Não foi possivel efetuar a gravação");
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Error during insert: " + a.Message);
                    }
                }
            }
        }
    }
}
