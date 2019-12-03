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
    public partial class FrmCadLocacao : Form
    {
        public FrmCadLocacao()
        {
            InitializeComponent();
        }

        private void btnsaircli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                cmbcliente.Focus(); // Coloca o foco no nome do cliente caso digite "não" no messagebox
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                cmbcliente.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void FrmCadLocacao_Load(object sender, EventArgs e)
        {
            cmbcliente.Focus();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))

            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbcliente.Focus();
            }

            else if (this.Controls.OfType<ComboBox>().Any(c => string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbcliente.Focus();
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string cliente = cmbcliente.Text;
                    string veiculo = cmbveiculo.Text; // Variavel combo utilizada para pegar string
                    string seguro = cmbseguro.Text;



                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_locacoes (idveiculo, valordiaria, kminicial," +
                            "datalocacao, datadevolucao, idcliente, idseguro) " +
                            "VALUES (@idveiculo, @valordiaria,  @kminicial, @datalocacao, @datadevolucao, @idcliente, @idseguro)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@idveiculo", veiculo.Substring(0, 2));
                            cmd.Parameters.Add("@valordiaria", Convert.ToString(txtdiaria.Text).Replace(',','.')); //
                            cmd.Parameters.Add("@kminicial", txtkmi.Text);
                            cmd.Parameters.AddWithValue("@datalocacao", Convert.ToDateTime(mstdatalocacao.Text).ToString("yyyy-MM-dd HH:mm"));
                            cmd.Parameters.AddWithValue("@datadevolucao", Convert.ToDateTime(mstdatadevolucao.Text).ToString("yyyy-MM-dd HH:mm"));
                            cmd.Parameters.Add("@idcliente", cliente.Substring(0, 3)); //
                            cmd.Parameters.Add("@idseguro", seguro.Substring(0, 2)); //


                            //cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                                cmbcliente.SelectedValue = "";
                                cmbseguro.SelectedValue = "";
                                txtdiaria.Clear();
                                txtkmi.Clear();
                                txtdiaria.Focus();
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

        private void cmbcliente_Click(object sender, EventArgs e)
        {
            cliente();
        }

        //---------------------------------------------------------------------------------------------

        public void veiculo()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_veiculos.id as varchar)   +  ' - ' +  tb_veiculos.modelo as VEICULO from tb_veiculos order by tb_veiculos.modelo";

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
                        this.cmbveiculo.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbveiculo.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbveiculo.ValueMember = "VEICULO";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }
        //-------------------------------------------------------------------------------------------------

        public void seguro()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_seguros.id as varchar)   +  ' - ' +  tb_seguros.descricao as SEGUROS from tb_seguros order by tb_seguros.descricao";

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
                        this.cmbseguro.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbseguro.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbseguro.ValueMember = "SEGUROS";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        private void cmbveiculo_Click(object sender, EventArgs e)
        {
            veiculo();
        }

        private void cmbseguro_Click(object sender, EventArgs e)
        {
            seguro();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            cmbcliente.SelectedValue = "";
            cmbseguro.SelectedValue = "";
            txtdiaria.Clear();
            txtkmi.Clear();
            txtdiaria.Focus();
            
        }
    }
}
