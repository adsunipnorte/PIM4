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
    public partial class FrmCadContatoCliente : Form
    {
        public FrmCadContatoCliente()
        {
            InitializeComponent();
        }

        private void FrmContatoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtnome.Focus(); // Coloca o foco no nome caso digite "não" no messagebox //
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtnome.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        public void tipoCliente()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(tb_clientes.id as varchar) +  ' - ' + tb_clientes.fantasia as CLIENTE from tb_clientes";

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
                        this.cmbtipocliente.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbtipocliente.DisplayMember = "id";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas)
                        this.cmbtipocliente.ValueMember = "cliente";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        private void cmbtipocliente_Click(object sender, EventArgs e)
        {
            tipoCliente();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnome.Text) || cmbtipocliente.Text == "")
            {
                MessageBox.Show("É necessario preencher o campo descrição e selecionar um tipo de cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Focus();
            }

            else
            {
                //ClasseConexaoBD conaaa = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                                                                //string var = "INSERT INTO tb_contatos(nome, idclientes)VALUES('" + txtnome.Text + "'" + cmbtipocliente.SelectedValue + ")"; // Variável que recebe comando SQL
                                                                //con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro




                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
    {
                    string combotipocliente = cmbtipocliente.Text; // Variavel combo utilizada para pegar string ID do cliente
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_contatos (nome, endereco, numero, complemento, bairro, cep, telefone, celular, email, idclientes) " +
                            "VALUES (@nome, @endereco, @numero, @complemento, @bairro, @cep, @telefone, @celular, @email, @idclientes)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@nome", txtnome.Text.ToUpper());
                            cmd.Parameters.Add("@endereco", txtend.Text.ToUpper());
                            cmd.Parameters.Add("@numero", txtnumero.Text);
                            cmd.Parameters.Add("@complemento", txtcompl.Text);
                            cmd.Parameters.Add("@bairro", txtbairro.Text.ToUpper());
                            cmd.Parameters.Add("@cep", txtcep.Text);
                            cmd.Parameters.Add("@telefone", txttel.Text);
                            cmd.Parameters.Add("@celular", txtcel.Text);
                            cmd.Parameters.Add("@email", txtemail.Text);
                            cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Não foi possivel efetuar a gravação");
                            }
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("Error ao inserir registro: " + a.Message);
                    }
                }




            }
        }

        private void cmbtipocliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
