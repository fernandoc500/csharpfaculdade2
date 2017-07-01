<%@ Page Title="Carrinho de Compras" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrinho.aspx.cs" Inherits="WingTipToysBatel.Views.Carrinho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><%: Title %></h1>
    <div style="align-content:center; width:70%">
    
        <asp:GridView runat="server" ID="grdCarrinho" runat="server"
         ItemType="WingTipToysBatel.Models.ItemVenda" SelectMethod="lstCarrinho_GetData"
        AutoGenerateColumns="false" CssClass="table table-striped table-hover">
        <Columns>
            <asp:BoundField HeaderText="Produto" DataField="produto.ProdutoNome" />
            <asp:BoundField HeaderText="Quantidade" DataField="Quantidade" />
            <asp:BoundField HeaderText="Preço" DataField="produto.ProdutoPreco" DataFormatString="{0:c}"/>
            <asp:TemplateField HeaderText="SubTotal">
                <ItemTemplate >
                    <%#: (Item.Quantidade * Item.produto.ProdutoPreco).ToString("C2") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remover">
                <ItemTemplate>
                    <a href="AdicionarAoCarrinho.aspx?produtoId=<%#: Item.produto.ProdutoId %>&remover=true">
                        <span class="fa fa-remove" style="color:red"></span>
                    </a>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>

    </asp:GridView>
    </div>
</asp:Content>

    
