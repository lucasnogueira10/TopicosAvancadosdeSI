<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="_24052021AgendaConsulta.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>
    <form id="form2" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Controle de Consultas</a> <span></span></h2>
                    <p></p>
                </div>
            </div>
        </article>

        <asp:HiddenField ID="HFId" runat="server" OnValueChanged="HFId_ValueChanged" />

        <div class="form-group">
            <label for="horario">Horário:</label>
            <asp:TextBox class="form-control" name="txtHorario" ID="txtHorario"
                runat="server"></asp:TextBox>
        </div>
        <asp:HiddenField ID="HiddenField1" runat="server" />



        <asp:Button ID="Salvar" runat="server" Text="Salvar" OnClick="Salvar_Click" />
    </form>

     <asp:GridView ID="GVClient" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="GVClient_RowCommand">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" />
                                <asp:BoundField DataField="Name" HeaderText="Nome" />
                                <asp:BoundField DataField="Telephone" HeaderText="Telefone" />
                                <asp:ButtonField ButtonType="Button" CommandName="EXCLUIR" Text="Excluir" />
                                <asp:ButtonField ButtonType="Button" CommandName="ALTERAR" Text="Alterar" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
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
