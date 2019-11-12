using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace PIM3.Desktop
{
    public class Cmethods
    {
        public static void AllowNumber(KeyPressEventArgs e) // Método permite somente digitar número em maskedtextbox
        {
            if (char.IsLetter(e.KeyChar) || //Letras
                char.IsSymbol(e.KeyChar) || //Símbolos
                char.IsWhiteSpace(e.KeyChar) || //Espaço
                char.IsPunctuation(e.KeyChar)) //Pontuação
                e.Handled = true; //Não permitir
                                  //Com o script acima é possível utilizar Números, 'Del', 'BackSpace'..

            //Abaixo só é permito de 0 a 9
            //if ((e.KeyChar < '0') || (e.KeyChar > '9')) e.Handled = true; //Allow only numbers
        }

        //---------------------------------------------------------------------------------------------

        public class inserir
        {
            public void Insertcombobox(string cidade, string nome, string estado)
            {
                using (SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=efleet;Integrated Security=True"))
                {
                    try
                    {

                        using (var cmd = new SqlCommand("INSERT INTO tb_cidades (codcidade, nome, idestados) VALUES (@codcidade, @nome, @idestados)"))
                        {

                            cmd.Connection = con;
                            cmd.Parameters.Add("@nome", nome);
                            cmd.Parameters.Add("@idestados", estado);
                            cmd.Parameters.Add("@codcidade", cidade);

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

        //----------------------------------------------------------------------------------------------

            public class limpar
        {
            public void limparCampos(Control.ControlCollection controles)
            {
                //Faz um laço para todos os controles passados no parâmetro
                foreach (Control ctrl in controles)
                {
                    //Se o contorle for um TextBox...
                    if (ctrl is TextBox)
                    {
                        ((TextBox)(ctrl)).Text = String.Empty;
                    }
                }
            }
        }

        




    }

}
