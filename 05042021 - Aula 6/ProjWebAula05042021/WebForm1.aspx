<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProjWebAula05042021.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
        .auto-style2 {
            width: 73px;
        }
        .auto-style3 {
            height: 25px;
            width: 73px;
        }
        .auto-style4 {
            width: 73px;
            height: 22px;
        }
        .auto-style5 {
            height: 22px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 73px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style4">
                    <asp:HiddenField ID="IdH" runat="server" />
                </td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style3">Descrição</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TxtDescricao" runat="server" Width="367px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Tipo</td>
                <td>
                    <asp:TextBox ID="TxtTipo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Marca</td>
                <td>
                    <asp:TextBox ID="TxtMarca" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Preço</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtPreco" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="LblMsg" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnSalvar" runat="server" OnClick="BtnSalvar_Click" Text="Salvar" />
                &nbsp;&nbsp;
                    <asp:Button ID="btnNovo" runat="server" OnClick="btnNovo_Click" Text="Novo" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:GridView ID="GVFerramenta" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" AutoGenerateColumns="False" CssClass="auto-style6" OnRowCommand="GVFerramenta_RowCommand" OnSelectedIndexChanged="GVFerramenta_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="Id" />
                            <asp:BoundField DataField="descricao" HeaderText="Descricao" />
                            <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                            <asp:BoundField DataField="marca" HeaderText="Marca" />
                            <asp:BoundField DataField="preco" HeaderText="Preco" />
                            <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Alterar" />
                            <asp:ButtonField ButtonType="Button" CommandName="Excluir" ShowHeader="True" Text="Excluir" />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
