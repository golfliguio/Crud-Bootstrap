<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>

     <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />

</head>

     <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <div class="container"></div>
            <div class="span10 offset-1"></div>
            <div class="row"></div>
            <h3 class="well">Detalhes do Cliente</h3>
            
            Informe o código:
            <br />
            <asp:TextBox ID="txtCodigo" runat="server" CssClass ="form-control" width="15%"/>
            <br />
            <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarCliente" />
            <a href="/Default.aspx" class="btn-default btn-lg ">Voltar</a>
            
            <br /><br />

            <asp:Panel ID ="pnlDados" runat="server" >

            Nome do Cliente:
            <br />
            <asp:TextBox ID="txtNome" runat="server" placeholder="Informe o nome do Cliente" CssClass ="form-control" width="50%"/>
             <br />
            Endereço do cliente:
            <br />
            <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereco" CssClass ="form-control" width="50%"/>
            <br />
            E-mail do Cliente:
            <br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass ="form-control" width="50%"/>
            <br /><br />

             <p>
                <asp:Label ID="lblMessagem" runat="server"/>
            </p>
            <asp:Button ID ="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluir_Click" />
            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-primary btn-lg" OnClick="btnAtualizar_Click" />
        
            
            </asp:Panel>
        </div>
    </form>
</body>
</html>
