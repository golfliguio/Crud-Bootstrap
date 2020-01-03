using System;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDal d = new PessoaDal();
                Pessoa p = d.PesquisarPorCodigo(Codigo);
                
                if(p!=null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                }
                else                
                {
                    lblMessagem.Text = " Cliente não encontrado!";
                    txtCodigo.Text= string.Empty;
                }
                    }

            catch (Exception ex)
            {

                lblMessagem.Text= ex.Message;
            }
        }
     
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
                try
                {
                    int Codigo = Convert.ToInt32(txtCodigo.Text);

                    Pessoa p = new Pessoa();

                    p.Codigo = Codigo;

                    PessoaDal d = new PessoaDal();

                    d.Excluir(p.Codigo);


                    lblMessagem.Text = " Cliente excluido com sucesso!! ";

                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEndereco.Text = string.Empty;

                }
                catch (Exception ex)
                {

                    lblMessagem.Text = ex.Message;
                }
            }
        

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
                try
                {
                    Pessoa p = new Pessoa();

                    p.Codigo = Convert.ToInt32(txtCodigo.Text);
                    p.Nome = Convert.ToString(txtNome.Text);
                    p.Endereco = Convert.ToString(txtEndereco.Text);
                    p.Email = Convert.ToString(txtEmail.Text);

                    PessoaDal d = new PessoaDal();

                    d.Atualizar(p);


                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtEndereco.Text = string.Empty;
                    txtEmail.Text = string.Empty;

                    lblMessagem.Text = " Cliente atualizado com sucesso!! ";
                }
                catch (Exception ex)
                {

                    lblMessagem.Text = ex.Message;
                }
            }

        }
    }
