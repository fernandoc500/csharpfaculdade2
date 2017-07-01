<%@ Page Title="Produtos" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ListaProdutos.aspx.cs" Inherits="WingTipToysBatel.Views.produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h2><%: Title %></h2>
    <div style="text-align:center">
        <asp:ListView id="lstProdutos" runat="server" 
            ItemType="WingTipToysBatel.Models.Produto"
            SelectMethod="lstProdutos_GetData"
            GroupItemCount="4">
            <ItemTemplate>
                <td>
                    <a href="DetalheProduto.aspx?ProdutoId=<%# Item.ProdutoId %>" style="font-size:8px">
                        <img src="../images/Thumbs/<%#:Item.ProdutoImagem%>" style="width:150px; height:120px; border:solid" />
                        <h6>Nome: <%#:Item.ProdutoNome%> </h6>  
                    </a>
                    <h6><b>Preço:</b> R$ <%#:Item.ProdutoPreco%> </h6>
                    <a href="AdicionarAoCarrinho.aspx?produtoId=<%# Item.ProdutoId %>" class="btn btn-primary" style="border-radius:5px">
                        <i class="fa fa-plus"></i>
                        Adicionar
                    </a>
                    <p>&nbsp;</p>
                </td> 
            </ItemTemplate >

            <GroupTemplate>
                <tr>
                    <div id="itemPlaceholder" runat="server"></div>
                </tr>     
            </GroupTemplate>

            <LayoutTemplate>
                <table style="width:100%; text-align:center">
                    <div id="groupPlaceholder" runat="server"></div>
                </table>   
            </LayoutTemplate>

        </asp:ListView>
    </div>
</asp:Content>
