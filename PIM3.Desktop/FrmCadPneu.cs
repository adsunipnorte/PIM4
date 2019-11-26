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
    public partial class FrmCadPneu : Form
    {
        public FrmCadPneu()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtperfilpneu.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
            }



        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))

            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtperfilpneu.Focus();
            }

            else if (this.Controls.OfType<ComboBox>().Any(c => string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtperfilpneu.Focus();
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string idveiculo = cmbveiculo.Text;
                    
                    string placaveiculo = cmbplacaveiculo.Text; // Variavel combo utilizada para pegar string ID do cliente
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_pneus (Perfil, DataCompra, Valor, IdVeiculo, PlacaVeiculo, Km)" +
                            "VALUES (@Perfil, @DataCompra, @Valor, @IdVeiculo, @PlacaVeiculo, @Km)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@Perfil", txtperfilpneu.Text.ToString());
                            //cmd.Parameters.Add("@nome", txtplaca.Text);
                            cmd.Parameters.Add("@DataCompra", mskdatacompra.Text);
                            //cmd.Parameters.Add("@marca", txtmarca.Text);
                            cmd.Parameters.Add("@Valor", txtvalor.Text);
                            cmd.Parameters.Add("@IdVeiculo", idveiculo.Substring(0, 4)); //
                            cmd.Parameters.Add("@PlacaVeiculo", placaveiculo.Substring(0, 6));
                            cmd.Parameters.Add("@Km", txtkmpneu.Text);
                            

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

        //----------------------------------------------------------------------------------------

        public void consultaveiculo()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "select cast(tb_veiculos.id as varchar) + ' - ' + tb_veiculos.modelo as VEICULO, tb_veiculos.placa from tb_veiculos order by tb_veiculos.modelo";

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
                        this.cmbveiculo.DisplayMember = "VEICULO";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbveiculo.ValueMember = "placa";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }


        public void consultaplacaveiculo(string placa)
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "select tb_veiculos.placa  from tb_veiculos where tb_veiculos.placa=";

            try
            {
                //Cria conexão com banco de dados
                using (SqlConnection conexao = new SqlConnection(con))
                {

                QuerySQL+= placa;
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
                        this.cmbveiculo.DisplayMember = "placa";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbveiculo.ValueMember = "placa";
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
            consultaveiculo();
        }

        private void cmbveiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbplacaveiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbplacaveiculo.SelectedValue.ToString();
        }

        private void cmbplacaveiculo_Click(object sender, EventArgs e)
        {
            string placa = cmbveiculo.SelectedValue.ToString();
            consultaplacaveiculo(placa);
        }
    }
}
