using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLLGenericaConexao;





namespace DLLComando
{
    public class SqlComandosDLL
    {
        public void InsertCentroCusto(string descricao)
        {
            DLLGenerica con = new DLLGenerica();
            string query = "insert into tb_centrocustos(descricao) values(" + "'" + descricao + "')";
            con.ConectaBD(query);
        }
    }
}
