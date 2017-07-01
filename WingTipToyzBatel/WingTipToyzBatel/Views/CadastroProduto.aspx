<%@ Page Title="Cadastro de Produtos" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="WingTipToysBatel.Views.CadastroProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center"><%:Title %></h1>

    <div class="form-horizontal" style="padding:3%">
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="lblProduto" for="txtNome">Nome do Produto</asp:Label>
            <div class="form-inline">
                <asp:TextBox runat="server" CssClass="form-control" id="txtNome" style="width:30%" placeholder="Nome do Produto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqNome" runat="server" 
                    ErrorMessage="Campo Obrigatório"
                     ControlToValidate="txtNome" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="Label2" for="txtCat">Categoria do Produto</asp:Label>
            <div class="form-inline">
               <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-control" style="width:30%" ></asp:DropDownList>
            </div>
        </div>
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="lblPreco" for="txtPreco">Preço do Produto</asp:Label>
            <div class="form-inline">
                <asp:TextBox runat="server" CssClass="form-control" id="txtPreco" style="width:30%" placeholder="Preço do Produto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqPreco" runat="server" 
                    ErrorMessage="Campo Obrigatório"
                     ControlToValidate="txtPreco" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="Label1" for="txtQuant">Quantidade do Produto</asp:Label>
            <div class="form-inline">
                <asp:TextBox runat="server" CssClass="form-control" id="txtQuant" style="width:30%" placeholder="Quantidade do Produto"></asp:TextBox>
            </div>
        </div>
        <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="lblImagem" for="txtImagem">Imagem do Produto</asp:Label>
            <div class="form-inline">
                <asp:TextBox runat="server" CssClass="form-control" id="txtImagem" style="width:30%" placeholder="Imagem do Produto"></asp:TextBox>
                <div class="form-inline">
                    <asp:FileUpload ID="fupImagem" runat="server"/>
                </div>
            </div>
        </div>

         <div class="form-group" style="padding:10px;">
            <asp:Label runat="server" ID="lblDescricao" for="txtDesc">Descrição do Produto</asp:Label>
            <div class="form-inline">
                <asp:TextBox TextMode="MultiLine" runat="server" CssClass="form-control" id="txtDesc" style="width:30%" placeholder="Descrição do Produto"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqDesc" runat="server" 
                    ErrorMessage="Campo Obrigatório"
                     ControlToValidate="txtDesc" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group" style="padding:10px; margin-left:15%">
            <div class="input-group">
                <asp:button runat="server" ID="btnLimparProduto" text="Limpar" CssClass="btn btn-default" style="border-radius:5px"  OnClick="btnLimparProduto_Click"/>
                <asp:button runat="server" ID="btnGravarProduto" text="Salvar" CssClass="btn btn-primary" style="border-radius:5px"  OnClick="btnGravarProduto_Click"/>
            </div>
        </div>
    </div>

</asp:Content>
