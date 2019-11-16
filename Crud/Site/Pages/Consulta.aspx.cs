using System;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaDal d = new PessoaDal();

                gridClientes.DataSource = d.Listar();//popular o grid view
                gridClientes.DataBind();//exibir o conteudo da grid
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }

        }
    }
}