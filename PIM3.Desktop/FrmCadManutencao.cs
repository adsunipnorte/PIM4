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
    public partial class FrmCadManutencao : Form
    {
        public FrmCadManutencao()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtdescricao.Focus(); // Coloca o foco na descrição caso digite "não" no messagebox
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
                txtdescricao.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))

            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }

            else if (this.Controls.OfType<ComboBox>().Any(c => string.IsNullOrEmpty(c.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdescricao.Focus();
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string tipomanutencao = cmbtpmanut.Text;
                    string comboveiculo = cmbveiculo.Text; // Variavel combo utilizada para pegar string ID do cliente
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_manutencao (descricao, idtipomanutencao, idveiculo) " +
                            "VALUES (@descricao, @idtipomanutencao, @idveiculo)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@descricao", txtdescricao.Text.ToUpper());
                            cmd.Parameters.Add("@idtipomanutencao", tipomanutencao.Substring(0,2));
                            cmd.Parameters.Add("@idveiculo", comboveiculo.Substring(0,2));
                            
                            
                            //cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                                txtdescricao.Clear();
                                cmbveiculo.SelectedValue = "";
                                cmbtpmanut.SelectedValue = "";
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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdescricao.Clear();
            cmbveiculo.SelectedValue = "";
            cmbtpmanut.SelectedValue = "";
            txtdescricao.Focus();
        }

        //------------------------------------------------------------------------------------

        public void tipomanutencao()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_tipomanutencao.id as varchar)   +  ' - ' +  tb_tipomanutencao.descricao as TIPOMANUTENCAO from tb_tipomanutencao order by tb_tipomanutencao.descricao";

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
                        this.cmbtpmanut.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbtpmanut.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbtpmanut.ValueMember = "TIPOMANUTENCAO";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        //--------------------------------------------------------------------------------------------

        public void veiculo()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_veiculos.id as varchar)   +  ' - ' +  tb_veiculos.modelo + ' ' + tb_veiculos.placa as VEICULO from tb_veiculos order by tb_veiculos.modelo";

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

        private void cmbtpmanut_Click(object sender, EventArgs e)
        {
            tipomanutencao();
        }

        private void cmbveiculo_Click(object sender, EventArgs e)
        {
            veiculo();
        }
    }
}
