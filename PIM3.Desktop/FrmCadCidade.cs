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
    public partial class FrmCadCidade : Form
    {
        public FrmCadCidade()
        {
            InitializeComponent();
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
                txtnomecid.Focus(); // Coloca foco no nome da cidade caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnsair.Enabled = false; // Botao foi desabilitado pois estava com erro ao fechar form
                this.Close();
            }
            else
            {
                txtnomecid.Focus(); // Coloca foco na descrição caso digite "não" no messagebox
            }
        }

        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            txtcodcidade.Clear();
            txtnomecid.Clear();
            cmbestado.Text = "";
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            
            
            if (this.Controls.OfType<TextBox>().Any(f => string.IsNullOrEmpty(f.Text)))
            {
                MessageBox.Show("É necessario preencher todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcodcidade.Focus();
            }

            else
            {
                //ClasseConexaoBD con = new ClasseConexaoBD(); // Variável do tipo da classe de conexão
                //string var = "INSERT INTO tb_cidades(codcidade, nome, idestados)VALUES('" + txtcodcidade.Text + "'," + "'" + txtnomecid.Text + "'," + "'" + cmbestado.GetItemText(cmbestado.SelectedItem) + "'" + ")"; // Variável que recebe comando SQL
                //con.AbreConexao(var); // Variável do tipo da classe de conexão com método de conexão e variável passada como parâmetro


                // ----------------------------------------------------------------------------------------------------------------------------------------------------

                
                string combo = cmbestado.Text; // Variavel combo utilizada para pegar string ID do estado

                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_cidades (codcidade, nome, idestados) VALUES (@codcidade, @nome, @idestados)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@codcidade", txtcodcidade.Text);
                            cmd.Parameters.Add("@nome", txtnomecid.Text);
                            cmd.Parameters.Add("@idestados", combo.Substring(0,2)); //utilzada variavel para pegar ID do estado

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Registro inserido com sucesso");
                                cmbestado.Text = "";
                                txtnomecid.Clear();
                                txtcodcidade.Clear();

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

        private void btngravar_TabIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;
        }

        public void estado()
        {
            string con = ("Data Source=(local);Initial Catalog=efleet;Integrated Security=True");
            string QuerySQL = "SELECT cast(id as varchar)  + ' - ' + estado as estado from tb_estados";
            

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
                        this.cmbestado.DataSource = dt;
                        //DisplayMember = recebe o nome que está no banco de dados
                        this.cmbestado.DisplayMember = "estado";
                        //ValueMember = recebe o código e guarda internamente em cada item do combobox. (nome das colunas concatenadas
                        this.cmbestado.ValueMember = "Estado";
                    }
                }
            }


            catch (Exception ex)
            {
                string err = ex.Message;
                err = "Falha : " + err;
            }

        }

        
        private void comboBox1_Click(object sender, EventArgs e)
        {
            estado();
        }
    }
}
