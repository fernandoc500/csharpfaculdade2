<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastrarProduto.aspx.cs" Inherits="WingTipToyzBatel.Views.CadastrarProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="row form-group">
            <div class="col-md-6">
                <asp:Label runat="server" ID="lblNome" Text="Nome: *" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqNome" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="txtNome" CssClass="text-danger"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6">
                <asp:Label runat="server" ID="lblDesc" Text="Descricao: *" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="txtDesc" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqDesc" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="txtDesc" CssClass="text-danger"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6">
                <asp:label runat="server" text="Preço: *"></asp:label>
                <asp:TextBox ID="txtPreco" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqPreco" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="txtPreco" CssClass="text-danger"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6">
                <asp:label runat="server" text="Quantidade: *"></asp:label>
                <asp:TextBox ID="txtQtd" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqQtd" runat="server" ErrorMessage="Campo obrigatório!" ControlToValidate="txtQtd" CssClass="text-danger"> </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6">
                <asp:label runat="server" text="Categoria: *"></asp:label>
                <asp:DropDownList ID="drpCategorias" runat="server" 
                    CssClass="form-control"
                    
                    />

            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-6">
                <asp:label runat="server" text="Imagem: *"></asp:label>
                <asp:FileUpload ID="fupImagem" runat="server" />
            </div>
        </div>
        <div class="row form-group">
            <div class="col-md-12 text-center">
                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-success" OnClick="btnSubmit_Click" Text="Gravar"/>
            </div>
        </div>
</asp:Content>
