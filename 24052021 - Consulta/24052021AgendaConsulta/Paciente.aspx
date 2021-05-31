<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="_24052021AgendaConsulta.Paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>
    <script>
 
    </script>
    <form id="form2" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Controle de Pacientes</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>
        <div class="form-group">
            <label for="nome">Nome:</label>
            <asp:TextBox class="form-control" name="txtNome" ID="txtNome"
                runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="telefone">Telefone:</label>
            <asp:TextBox class="form-control" name="txtTelefone" ID="txtTelefone"
                runat="server"></asp:TextBox>
        </div>
           <div class="form-group">
            <label for="endereco">Endereço:</label>
            <asp:TextBox class="form-control" name="txtEndereco" ID="txtEndereco"
                runat="server"></asp:TextBox>
        </div>
 
        <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar"
            OnClick="btnCadastrar_Click" />
    </form>
    <br />
    <% if (!String.IsNullOrEmpty(lblmsg.Text))
        {%>
    <div class="alert alert-success">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong>
    </div>
    <%} %>
</body>
</html>
