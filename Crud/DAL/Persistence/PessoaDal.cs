using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DAL.Persistence
{

    /// <summary>
    /// 
    /// (localdb)\MSSQLLocalDB
    /// 
    /// </summary>
    /// 



    // regra de negocio - consultas

    public class PessoaDal : Conexao
    {


        public void Gravar(Pessoa p)
        {
            try
            {
                //abrir conexao

                AbrirConexao();

                Cmd = new SqlCommand("insert into Pessoa(Nome,Endereco,Email) values (@v1,@v2,@v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);

                Cmd.ExecuteNonQuery();//executa o metodo
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao gravar cliente - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }    //gravar dados : insert

        public void Atualizar(Pessoa p) //update
        {
            try
            {
                AbrirConexao();

               
               Cmd = new SqlCommand("update Pessoa set Nome=  @v1, Endereco= @v2, Email= @v3 where Codigo= @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", p.Nome);
                Cmd.Parameters.AddWithValue("@v2", p.Endereco);
                Cmd.Parameters.AddWithValue("@v3", p.Email);
                Cmd.Parameters.AddWithValue("@v4", p.Codigo);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao atualizar cliente - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int Codigo)//delete
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("delete  from Pessoa where Codigo = @v1", Con);


                Cmd.Parameters.AddWithValue("@v1", Codigo) ;

              
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(" - Erro ao excluir o cliente - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa PesquisarPorCodigo(int Codigo)//obter pessoa por codigo - chave primaria
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Pessoa where Codigo = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Codigo);

                Dr = Cmd.ExecuteReader();//execuçao da leitura do bd

                Pessoa p = null;//cria ponteiro

                if (Dr.Read())
                {
                    p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                }

                return p;
            }
            catch (Exception ex)
            {

                throw new Exception(" - Código não encontrado - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> Listar()  //listar todos clientes cadastrados
        {
            try
            {
                AbrirConexao();

                Cmd = new SqlCommand("select * from Pessoa", Con);

                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();//lista vazia

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Endereco = Convert.ToString(Dr["Endereco"]);
                    p.Email = Convert.ToString(Dr["Email"]);

                    lista.Add(p);
                }
                return lista;


            }
            catch (Exception ex)
            {

                throw new Exception(" - Não foi possivel Listar os  clientes! - " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
