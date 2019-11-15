using System;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            //captura valor dropdownlist

            string Opcao = ddlMenu.SelectedValue;

            switch (Opcao)
            {
                case "0":

                    lblMensagem.Text = "Por favor selecione uma opção válida!!";
                    break;

                case "1":

                    Response.Redirect("/Pages/Cadastro.aspx");
                    break;

                case "2":

                    Response.Redirect("/Pages/Consulta.aspx");
                    break;

                case "3":

                    Response.Redirect("/Pages/Detalhes.aspx");
                    break;

            }
        }
    }
}