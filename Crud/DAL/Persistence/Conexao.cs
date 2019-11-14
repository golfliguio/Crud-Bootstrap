using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Persistence
{
   public class Conexao
    {
        protected SqlConnection Con;//estabelecer conexao
        protected SqlCommand Cmd;//comandos sql
        protected SqlDataReader Dr;// ler registros query

        //abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=(localdb)/MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");//conection string
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception (ex.Message);
            }
        }
    }
}
