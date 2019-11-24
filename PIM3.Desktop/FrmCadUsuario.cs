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
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {

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
                txtnome.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }


        public void perfilUsuario()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(id as varchar) + ' - ' + descricao as descricao from tb_perfilusuarios";

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
                        this.cmbpuser.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbpuser.DisplayMember = "descricao";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox.
                        this.cmbpuser.ValueMember = "descricao";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }
        }

        private void cmbpuser_Click(object sender, EventArgs e)
        {
            perfilUsuario();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnome.Text) || cmbpuser.Text == "")
            {
                MessageBox.Show("É necessario preencher os campos com asterisco em vermelho.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnome.Focus();
            }

            else
            {
                //ClasseConexaoBD conaaa = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                //string var = "INSERT INTO tb_contatos(nome, idclientes)VALUES('" + txtnome.Text + "'" + cmbtipocliente.SelectedValue + ")"; // Variável que recebe comando SQL
                //con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro




                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    string combousuario = cmbpuser.Text; // Variavel combo utilizada para pegar string ID do cliente
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_usuarios (login, nome, senha, situacao, email, idperfilusuarios) " +
                            "VALUES (@login, @nome, @senha, @situacao, @email, @idperfilusuarios)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@login", txtlogin.Text);
                            cmd.Parameters.Add("@nome", txtnome.Text);
                            cmd.Parameters.Add("@senha", txtsenha.Text);
                            cmd.Parameters.Add("@situacao", 1);
                            cmd.Parameters.Add("@email", txtemail.Text);
                            cmd.Parameters.Add("@idperfilusuarios", combousuario.Substring(0,2));
                            //cmd.Parameters.Add("@idclientes", combotipocliente.Substring(0, 2)); //utilzada variavel para pegar ID do cliente

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                                txtnome.Clear();
                                txtlogin.Clear();
                                txtsenha.Clear();
                                txtemail.Clear();
                                cmbpuser.SelectedValue = "";
                                txtnome.Focus();
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
    }
}
