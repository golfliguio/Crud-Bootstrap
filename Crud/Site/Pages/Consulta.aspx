<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Consulta</title>
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
            <h3 class="well">Consulta de Clientes</h3>

            <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#99ff66">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo"/>
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                <asp:BoundField DataField="Email" HeaderText="E-mail" />
            </Columns>
            <RowStyle CssClass="cursor-pointer"/>
            </asp:GridView>

            <p>
                <asp:Label ID="lblMessage" runat="server"/>
            </p>

             <a href="/Default.aspx" class="btn-primary btn-lg ">Voltar</a>

     
        </div>
    </form>
</body>
</html>
