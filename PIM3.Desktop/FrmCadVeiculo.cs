using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PIM3.Desktop
{
    public partial class FrmCadVeiculo : Form
    {
        public FrmCadVeiculo()
        {
            InitializeComponent();
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
                txtplaca.Focus(); // Coloca foco na placa caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtplaca.Clear();
            txtrenavam.Clear();
            txtmarca.Clear();
            txtmodelo.Clear();
            txtcor.Clear();
            cmblugares.Text = "";
            cmbcambio.Text = "";
            cmbcombustivel.Text = "";
            cmbporta.Text = "";
            rtbobs.Clear();
            //Cmethods.limpar(this.Controls);
        }

        private void btnsucesso_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text))) 
                
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtplaca.Focus();
            }

            else if (this.Controls.OfType<ComboBox>().Any(c => string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtplaca.Focus();
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string lugares = cmblugares.Text;
                    string tipoveiculo = cmbtipoveiculo.Text;
                    string tpmontadora = cmbmontadora.Text;
                    string anofab = cmbanofabricacao.Text;
                    string anomodel = cmbanomodelo.Text;
                    string numporta = cmbporta.Text;
                    string motor = cmbmotor.Text;
                    string combotipoveiculo = cmbtipoveiculo.Text; // Variavel combo utilizada para pegar string ID do cliente
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_veiculos (placa, renavam, marca, modelo, anofabricacao, anomodelo, cor, porta," +
                            "motor, cambio, combustivel, lugares, idtipoveiculo, idmontadoras, observacao) " +
                            "VALUES (@placa, @renavam, @marca, @modelo, @anofabricacao, @anomodelo, @cor, @porta, @motor, @cambio, @combustivel, @lugares, @idtipoveiculo, @idmontadoras, @observacao)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@placa", txtplaca.Text);
                            //cmd.Parameters.Add("@nome", txtplaca.Text);
                            cmd.Parameters.Add("@renavam", txtrenavam.Text);
                            cmd.Parameters.Add("@marca", txtmarca.Text);
                            cmd.Parameters.Add("@modelo", txtmodelo.Text);
                            cmd.Parameters.Add("@anomodelo", anomodel.Substring(0,4)); //
                            cmd.Parameters.Add("@anofabricacao", anofab.Substring(0,4));
                            cmd.Parameters.Add("@cor", txtcor.Text);
                            cmd.Parameters.Add("@porta", numporta.Substring(0,1)); //
                            cmd.Parameters.Add("@motor", motor.Substring(0,3)); //
                            cmd.Parameters.Add("@cambio", cmbcambio.Text); //
                            cmd.Parameters.Add("@combustivel", cmbcombustivel.Text);
                            cmd.Parameters.Add("@lugares", lugares.Substring(0,1));
                            cmd.Parameters.Add("@idtipoveiculo", tipoveiculo.Substring(0, 1));
                            cmd.Parameters.Add("@idmontadoras", tpmontadora.Substring(0,2));
                            cmd.Parameters.Add("@observacao", rtbobs.Text);

                            //cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Não foi possive efetuar a gravação");
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
        public void tipoVeiculo()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_tipoveiculo.id as varchar) +  ' - ' + tb_tipoveiculo.descricao as TIPOVEICULO from tb_tipoveiculo";

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
                        this.cmbtipoveiculo.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbtipoveiculo.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbtipoveiculo.ValueMember = "TIPOVEICULO";
                    }
                }
            }
            

            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        private void cmbtipoveiculo_Click(object sender, EventArgs e)
        {
            tipoVeiculo();
            
        }


        public void consultamontadora()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_montadoras.id as varchar) +  ' - ' + tb_montadoras.descricao as MONTADORA from tb_montadoras";

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
                        this.cmbmontadora.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbmontadora.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbmontadora.ValueMember = "MONTADORA";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        private void cmbmontadora_Click(object sender, EventArgs e)
        {
            consultamontadora();
        }
    }
    //-----------------------------------------------------------------------------------------------------
    
    



}

