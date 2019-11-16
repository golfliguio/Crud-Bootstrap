using DAL.Model;
using DAL.Persistence;
using System;


namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();

                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;


                PessoaDal d = new PessoaDal();
                d.Gravar(p);//gravar pessoa

                lblMenssagem.Text = " Cliente " + p.Nome + " - Cadastrado com sucesso!!";

                txtNome.Text = " ";
                txtEndereco.Text = " ";
                txtEmail.Text = " ";
            }
            catch (Exception ex)
            {

                lblMenssagem.Text = ex.Message;
            }
        }
    }
}