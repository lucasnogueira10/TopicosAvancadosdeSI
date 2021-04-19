<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ProjCadastro.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Lanches</title>
        <style>
            table,th,td{
                border: 1px solid black;
                border-collapse: collapse;
            }

            th, td {
                padding: 5px 10px;
            }

            th{
                background-color: black;
                color: white;
            }

            *{
                font-family: Arial, Helvetica, sans-serif;
            }
            /*Odd aplicado em todos elementos impares*/

            table tr:nth-child(odd){
                background-color: #ddd;
            }

             /*Odd aplicado em todos elementos pares*/
            table tr:nth-child(even){
                background-color: white;
            }

            * {
                margin:10px auto
            }

            .auto-style1 {
                width: 235px;
            }

            .auto-style2 {
                width: 18%;
                height: 9%;
                
            }

        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div align="middle">
                <img src="logo.png" align="middle" class="auto-style2">
            
            </div>
            <div>
                <h2 align="middle">
                    Realizar Pedidos <a href="WebForm1.aspx">Clique Aqui</a>
                </h2>
            </div>
            <table>
                <tr>
                    <td>
                        Nome:
                    </td> 
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtNome" runat="server" Width="188px"></asp:TextBox> 
                    </td>
                </tr>
       
                <tr>
                    <td>
                        Descrição: 
                    </td> 
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtDescricao" runat="server" Width="186px"></asp:TextBox> 
                    </td>
                </tr>
                <tr>
                    <td>
                       Valor: 
                    </td> 
                    <td class="auto-style1">
                        <asp:TextBox ID="TxtValor" runat="server" Width="186px"></asp:TextBox> 

                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td class="auto-style1">
                        <asp:Button ID="btnCriar" runat="server" Text="Criar" OnClick="btnCriar_Click" />
                        <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" Width="196px" Height="143px">
        </asp:GridView>
    </form>
</body>
</html>

