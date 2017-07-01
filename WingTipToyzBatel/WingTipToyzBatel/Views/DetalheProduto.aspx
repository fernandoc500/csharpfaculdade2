<%@ Page Title="Detalhe Produto" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="DetalheProduto.aspx.cs" Inherits="WingTipToysBatel.Views.DetalheProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:FormView id="frvProduto" runat="server" ItemType="WingTipToysBatel.Models.Produto" SelectMethod="frvProduto_GetItem">
        <ItemTemplate>
            <div class="row"> 
                <h1><%#:Item.ProdutoNome%> </h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="../images/<%#:Item.ProdutoImagem %>" style="border:solid;height:200px"/>
                    </td>
                    <td style="vertical-align:top; padding-left:30px">
                        <b>Descrição:</b><h5><%#:Item.ProdutoDescricao %></h5>
                        <b>Preço:</b><h5>R$<%#: Item.ProdutoPreco.ToString("C2") %></h5>
                        <b>Quantidade:</b><h5><%#:Item.ProdutoQuantidade %></h5>
                        <br />
                        <a href="AdicionarAoCarrinho.aspx?produtoId=<%# Item.ProdutoId %>" class="btn btn-primary" style="border-radius:5px">
                        <i class="fa fa-plus"></i>
                        Adicionar
                    </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
