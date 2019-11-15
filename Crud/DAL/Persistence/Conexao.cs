using System;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {


        /// <summary>
        /// 
        /// (localdb)\MSSQLLocalDB
        /// 
        /// </summary>
        /// 



        protected SqlConnection Con;//estabelecer conexao
        protected SqlCommand Cmd;//comandos sql
        protected SqlDataReader Dr;// ler registros query

        //abrir conexao
        protected void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");//conection string
                


                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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

                throw new Exception(ex.Message);
            }
        }
    }
}
